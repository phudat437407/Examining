using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.DTO
{
    public class AccountDTO
    {
        [StringLength(20, MinimumLength = 6)]
        [Required]
        public string Username { get; set; }

        [StringLength(20, MinimumLength = 6)]
        [Required]
        public string Password { get; set; }
    }
}