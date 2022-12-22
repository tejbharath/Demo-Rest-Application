using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Demo.Logic;
using Demo.Models;

namespace Demo.Controllers
{
    [RoutePrefix("customers")]
    public class CustomersController : ApiController
    {
        private readonly ICustomerManager _customerManager;

        public CustomersController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }

        [Route("{customerId:int}")]
        [ResponseType(typeof(Customer))]
        [HttpGet]
        public async Task<IHttpActionResult> GetCustomer(int customerId)
        {
            try
            {
                var customer = await _customerManager.GetCustomer(customerId);
                return Ok(customer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}