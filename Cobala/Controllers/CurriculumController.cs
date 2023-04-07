using Microsoft.AspNetCore.Mvc;

namespace Cobala.Controllers
{
    [Route("curriculum")]
    public class CurriculumController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
