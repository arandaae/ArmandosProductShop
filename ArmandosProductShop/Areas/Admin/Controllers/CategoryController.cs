using ArmandosProductShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ArmandosProductShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private ShopContext context;

        public CategoryController(ShopContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List","Category");
        }

        [Route("[area]/Categories/{id?}")]
        public IActionResult List()
        {
            var categories = context.Categories.OrderBy(c => c.CategoryID).ToList();
            return View(categories);
        }
        /// <summary>
        /// Add new category
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("AddUpdate", new Category());
        }

        /// <summary>
        /// Update an exsisting category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Action = "Update";
            var category = context.Categories.Find(id);
            return View("AddUpdate", category);
        }

        /// <summary>
        /// Update or add category to database
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Update(Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.CategoryID == 0)
                {
                    context.Categories.Add(category);
                }
                else
                {
                    context.Categories.Update(category);
                }
                context.SaveChanges(); //Saves the updated category or Adds a new category to the database

                return RedirectToAction("List", "Category"); //Return to List action inside the Category controller
            }
            else
            {
                ViewBag.Action = "Save";
                return View("AddUpdate"); //Return the current view
            }
        }

        /// <summary>
        /// Delete category from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = context.Categories.Find(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
            context.Categories.Remove(category);
            context.SaveChanges();
            return RedirectToAction("List", "Category");
        }

    }
}
