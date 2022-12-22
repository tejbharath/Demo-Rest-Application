using System.Threading.Tasks;
using Demo.Models;

namespace Demo.DataAccess
{
    public interface IDataAccess
    {
        Task<Customer> GetCustomer(int customerId);
    }
}
