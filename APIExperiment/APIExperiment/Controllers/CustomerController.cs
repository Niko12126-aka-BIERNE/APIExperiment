using Microsoft.AspNetCore.Mvc;

namespace APIExperiment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly FakeDB fakeDB;

        public CustomerController()
        {
            fakeDB = new();
        }

        [HttpGet(Name = "GetRandomCustomer")]
        public Customer Get()
        {
            return fakeDB.GetRandomCustomer();
        }
    }
}
