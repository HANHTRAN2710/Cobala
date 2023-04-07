using Microsoft.AspNetCore.Mvc;

namespace Cobala.Controllers
{
    [Route("contact")]
    public class ContactController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
