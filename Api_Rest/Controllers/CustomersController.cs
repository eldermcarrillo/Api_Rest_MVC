using System.Web.Http;
using System.Linq;
using Api_Rest.Context;

namespace Api_Rest.Controllers
{
    [Authorize]
    [RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {
        Db_Context db = new Db_Context();
        [HttpGet]
        public IHttpActionResult GetId(int id)
        {
            var customerFake = "customer-fake";
            return Ok(customerFake);
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var customers = db.customers.ToList();
            return Ok(customers);
        }
    }
}
