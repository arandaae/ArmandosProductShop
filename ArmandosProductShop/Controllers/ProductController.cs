using System;
using System.Linq;
using System.Threading.Tasks;
using ArmandosProductShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ArmandosProductShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail(string slugLink)
        {
            Product product = DataBase.GetProduct(slugLink);
            return View(product);
        }

        public IActionResult List()
        {
            List<Product> products = DataBase.GetProducts();
            return View(products);
        }
    }
}
