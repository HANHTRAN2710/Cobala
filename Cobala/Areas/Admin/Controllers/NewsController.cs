using Cobala.Areas.Admin.Services;
using Cobala.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cobala.Areas.Admin.Controllers
{
    [Route("new")]
    public class NewsController : Controller
    {
        private NewService newService;
        public NewsController(NewService _newService)
        {
            newService = _newService;
        }
        [Route("addnew")]
        public IActionResult Addnew()
        {
            
                ViewBag.tintuces = newService.findAll();

                return View("Addnew");


        }
        
        [Route("viewnew")]
        public IActionResult Viewnew()
        {
            ViewBag.tintuces = newService.findAll();
            return View();
        }
        
        //[Route("edit/{id}")]
        //public IActionResult Editnew(int id)
        //{
        //    var tintuc = newService.findById(id);
        //    ViewBag.tintuces = newService.findAll();
        //    return View("Editnew", tintuc);
        //}
        //[HttpPost]
        //[Route("edit/{id}")]
        //public IActionResult Edinewt(int id, Tintuc tintuc)
        //{

        //    if (newService.Update(tintuc))
        //    {
        //        TempData["msg"] = "Done";
        //    }
        //    else
        //    {
        //        TempData["msg"] = "Failed";
        //    }
        //    return RedirectToAction("Viewnew");
        //}
    }
}
