using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Demo.Models;

namespace Demo.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private readonly string _connectionString;

        public DataAccess()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DemoDB"].ConnectionString;
        }

        public async Task<Customer> GetCustomer(int customerId)
        {
            using (var context = new DbContext(_connectionString))
            {
                var customerIdParam = new SqlParameter("@CustomerId", customerId);

                return await context.Database.SqlQuery<Customer>("exec dbo.Customer_S @CustomerId ",
                    customerIdParam).FirstOrDefaultAsync();
            }
        }
}
}