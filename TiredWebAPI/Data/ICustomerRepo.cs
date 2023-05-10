using Microsoft.Extensions.Primitives;
using TiredWebAPI.Models;

namespace TiredWebAPI.Data
{
    public interface ICustomerRepo
    {
        public ICollection<Customer> GetCustomers();
        public Customer GetCustomer(int id);
        public void CreateCustomer(Customer customer);
    }
}
