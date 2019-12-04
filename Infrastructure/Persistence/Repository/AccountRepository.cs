using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Infrastructure.Persistence.Repository
{
    public class AccountRepository : EFRepository<Account>,  IAccountRepository
    {
        public AccountRepository(RegisterContext context) : base(context)
       {
           
       }
       protected new RegisterContext Context => base.Context as RegisterContext;
    }
}