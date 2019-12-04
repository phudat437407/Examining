using System.Collections.Generic;
using ApplicationCore.DTO;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Specifications;
using AutoMapper;

namespace ApplicationCore.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AccountService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void CreateAccount(Account Account)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAccount(string id)
        {
            throw new System.NotImplementedException();
        }

        public Account GetAccount(string id)
        {
            return _unitOfWork.Accounts.GetBy(id);
        }

        public IEnumerable<AccountDTO> GetAccounts(int pageIndex, int pageSize, out int count)
        {
            count = 4; 
             var AccountSpecPaging = new AccountSpecification(pageIndex, pageSize);

            var Accounts = _unitOfWork.Accounts.Find(AccountSpecPaging);
            return _mapper.Map<IEnumerable<Account>, IEnumerable<AccountDTO>>(Accounts);
        }

        public void UpdateAccount(Account Account)
        {
            throw new System.NotImplementedException();
        }
    }
}