using System.Threading.Tasks;
using Demo.DataAccess;
using Demo.Models;

namespace Demo.Logic
{
    public class CustomerManager : ICustomerManager
    {
        private readonly IDataAccess _dataAccess;

        public CustomerManager(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public  async Task<Customer> GetCustomer(int customerId)
        {
            return await _dataAccess.GetCustomer(customerId);
        }
    }
}