using System.Web.Http;
using System.Linq;
using Api_Rest.Context;
using Newtonsoft.Json;

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
            //var customers = db.customers.ToList();
            var customers = (
                             
                             from c in db.customers
                             join t in db.TypeCustomers on c.IdT equals t.IdT select new {c.Id_C , c.Name}
                             ).ToList();
            return Ok(JsonConvert.SerializeObject(customers));
        }
    }
}
