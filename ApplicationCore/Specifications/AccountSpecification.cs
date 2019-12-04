using ApplicationCore.Entities;

namespace ApplicationCore.Specifications
{
    public class AccountSpecification : Specification<Account>
    {
        public AccountSpecification(int pageIndex, int pageSize)
            : base(m => true)
        {
            ApplyPaging(pageIndex, pageSize);
        }
    }
}