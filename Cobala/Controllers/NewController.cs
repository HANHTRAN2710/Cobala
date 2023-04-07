using Microsoft.AspNetCore.Mvc;

namespace Cobala.Controllers
{
    [Route("new")]
    public class NewController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
