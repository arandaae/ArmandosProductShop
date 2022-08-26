using ArmandosProductShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ArmandosProductShop.Controllers
{
    public class ProductController : Controller
    {
        private ShopContext context;

        public ProductController(ShopContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List", "Products");
        }

        public IActionResult Detail(int id) // Get the id of the product and display the View with the details of this product
        {
            var categories = context.Categories.OrderBy(c => c.CategoryID).ToList();

            Product product = context.Products.Find(id); //Find the product that matches the id
            var categoryName = "";
            foreach (var category in categories)
            {
                if (category.CategoryID == product.CategoryID)
                {
                    categoryName = category.Name;
                }
            }

            string imageFileName = product.Code + "-m.jpg";

            ViewBag.CategoryName = categoryName;
            ViewBag.ImageFileName = imageFileName;
            return View(product);
        }

        [Route("[controller]s/{id?}")]
        public IActionResult List(string id = "All")
        {
            var categories = context.Categories.OrderBy(c => c.CategoryID).ToList(); // Get all of the categories and sort it by id

            List<Product> products;

            if (id == "All")
            {
                products = context.Products.OrderBy(p => p.ProductID).ToList(); // Gets all the products if there is no id specified for this action 
            }
            else if (id == "Specials") //Products that are currently available at a special price
            {
                products = context.Products.Where(p => p.Price < 5.0M).OrderBy(p => p.ProductID).ToList();
            }
            else
            {
                products = context.Products.Where(p => p.Category.Name == id).OrderBy(p => p.ProductID).ToList();
            }

            ViewBag.SelectedCategoryName = id;
            ViewBag.AllCategories = categories;

            return View(products);
        }

    }
}
