using TiredWebAPI.Models;

namespace TiredWebAPI.Data
{
    public interface IAccountRepo
    {

        public ICollection<BankAccount> GetBankAccounts();
        public ICollection<BankAccount> GetCustomerAccounts(int CustomerId);
        public void CreateBankAccount(BankAccount bankAccount);
        public decimal GetTotalBalance(int CustomerID);
    }
}
