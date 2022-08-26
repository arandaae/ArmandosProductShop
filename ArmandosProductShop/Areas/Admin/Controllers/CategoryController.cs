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

    }
}
