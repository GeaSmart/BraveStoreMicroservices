using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [ApiController]
    [Route("/")]
    public class DefaultController
    {
        [HttpGet]
        public string Get()
        {
            return "Running...";
        }
    }
}
