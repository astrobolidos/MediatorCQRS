using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class WelcomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Welcome stranger";
        }
    }
}
