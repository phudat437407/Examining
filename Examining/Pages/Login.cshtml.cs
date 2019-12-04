using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Examining.Pages
{
    public class LoginModel  : PageModel
    {
        private readonly IAccountService _service;
        public const string SessionKeyName = "_Name";
        public LoginModel(IAccountService servie) 
        {
               
                 this._service = servie;
        }

        public IActionResult OnPost()
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    msg = "Hãy nhập tài khoản và mật khẩu";
                    return Page();
                }
                if(!AccountExists(username))
                {
                     msg = "tài khoản không tồn tại";
                    return Page();
                    
                }
                if(!_service.GetAccount(username).Password.Equals(password))
                {
                        msg = "sai tên tài khoản hoặc mật khẩu";
                        return Page();
                }

                 HttpContext.Session.SetString(SessionKeyName, username);
                 return RedirectToPage("Index");
            }
        private bool AccountExists(string id)
        {
            return _service.GetAccount(id) != null;
        }
        
        [TempData]
         public string msg{get; set;}
         [BindProperty]
         public string username{get; set;}
         [BindProperty]
         public string password{get; set;}
         public Account Account { get; set; }
    }
}