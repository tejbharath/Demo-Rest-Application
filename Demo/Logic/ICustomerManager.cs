using System.Threading.Tasks;
using Demo.Models;

namespace Demo.Logic
{
    public interface ICustomerManager
    {
        Task<Customer> GetCustomer(int customerId);
    }
}
