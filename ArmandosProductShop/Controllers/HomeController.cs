using ArmandosProductShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ArmandosProductShop.Controllers
{
    public class HomeController : Controller
    {       
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")] // When the user types local host/About this action will be executed and the corresponding View will load
        public IActionResult About()
        {
            return View();
        }

    }
}
