using System.Collections.Generic;
using ApplicationCore.DTO;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IAccountService
    {
        Account GetAccount(string id);
        IEnumerable<AccountDTO> GetAccounts(int pageIndex, int pageSize, out int count);
        void CreateAccount(Account Account); // them moi bac si
        void UpdateAccount(Account Account);
        void DeleteAccount(string id);
    }
}