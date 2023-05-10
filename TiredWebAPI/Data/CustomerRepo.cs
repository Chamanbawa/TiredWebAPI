using TiredWebAPI.Models;

namespace TiredWebAPI.Data
{
    public class CustomerRepo : ICustomerRepo
    {
        private TiredWebAPIContext _context;
        public CustomerRepo(TiredWebAPIContext context)
        {
            _context = context;
        }

        public ICollection<Customer> GetCustomers()
        {
            return _context.Customer.ToList();
        }
        public Customer GetCustomer(int id)
        {
            return _context.Customer.Find(id);
        }
        public void CreateCustomer(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();
        }
    }
}
