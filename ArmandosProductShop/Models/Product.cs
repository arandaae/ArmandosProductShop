using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArmandosProductShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArmandosProductShop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name {get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// This will replace spaces with - in the url for products
        /// </summary>
        public string Slug => Name.Replace(' ', '-');
    }
}
