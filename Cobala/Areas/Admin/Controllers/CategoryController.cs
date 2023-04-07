using Cobala.Areas.Admin.Services;
using Cobala.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cobala.Areas.Admin.Controllers
{
        [Area("admin")]
        [Route("admin/category")]
        public class CategoryController : Controller
        {
            private CategoryService categoryService;
            public CategoryController(CategoryService _categoryService)
            {
                categoryService = _categoryService;
            }
            [Route("addcategory")]
            public IActionResult Addcategory()
            {
                ViewBag.categories = categoryService.findAll();

                return View("Addcategory");


            }   
            [HttpPost]
            [Route("addcategory")]
            public IActionResult Addcategory(Category category)
            {
                if (categoryService.Create(category))
                {
                    TempData["msg"] = "Success";
                }
                else
                {
                    TempData["msg"] = "Faild";
                }
                return RedirectToAction("Addcategory");
            }
            [Route("edit/{id}")]
            public IActionResult Edit(int id)
            {
                var category = categoryService.findById(id);
                ViewBag.categories = categoryService.findAll();
                return View("EditCategory", category);
            }
            [Route("Viewcategory")]
            public IActionResult Viewcategory()
            {
                ViewBag.categories = categoryService.findAll();
                return View();
            }
            [HttpPost]
            [Route("edit/{id}")]
            public IActionResult Edit(int id, Category category)
            {

                if (categoryService.Update(category))
                {
                    TempData["msg"] = "Done";
                }
                else
                {
                    TempData["msg"] = "Failed";
                }
                return RedirectToAction("Viewcategory");
            }
        }
}
