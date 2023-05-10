using TiredWebAPI.Models;

namespace TiredWebAPI.Data
{
    public class AccountRepo:IAccountRepo
    {
        //Create Basic CRUD methods for Accounts and customers in an AcountRepository and a CustomerREpository

        private TiredWebAPIContext _context;
        public AccountRepo(TiredWebAPIContext context)
        {
            _context = context;
        }

        public ICollection<BankAccount> GetBankAccounts()
        {
            return _context.BankAccount.ToList();
        }

        public ICollection<BankAccount> GetCustomerAccounts(int CustomerId)
        {
            return _context.BankAccount.Where(ba => ba.CustomerId == CustomerId).ToList();

        }

      public void CreateBankAccount(BankAccount bankAccount)
        {
            _context.BankAccount.Add(bankAccount);
            _context.SaveChanges();
        }
        public decimal GetTotalBalance(int CustomerId)
        {
           return _context.BankAccount.Where(ba => ba.CustomerId == CustomerId).Select(ba => ba.Balance).Sum();
        }

    }
}
