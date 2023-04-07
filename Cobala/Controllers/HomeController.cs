using Microsoft.AspNetCore.Mvc;

namespace Cobala.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        [Route("~/")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("tretuki")]
        public IActionResult Autisticchildren()
        {
            return View("tretuki");
        }
        [Route("champhattrientritue")]
        public IActionResult Champhattrientritue()
        {
            return View("champhattrientritue");
        }
        [Route("roiloanngonngu")]
        public IActionResult Roiloanngonngu()
        {
            return View("roiloanngonngu");
        }
        [Route("chamnoi")]
        public IActionResult Chamnoi()
        {
            return View("chamnoi");
        }
        [Route("tangdonggiamchuy")]
        public IActionResult Tangdonggiamchuy()
        {
            return View("tangdonggiamchuy");
        }
        [Route("khokhanhoctap")]
        public IActionResult Khokhanhoctap()
        {
            return View("khokhanhoctap");
        }
        [Route("trehoanhapcuocsong")]
        public IActionResult Trehoanhapcuocsong()
        {
            return View("trehoanhapcuocsong");
        }
        [Route("hoichungdown")]
        public IActionResult Hoichungdown()
        {
            return View("hoichungdown");
        }
    }
}
