using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArmandosProductShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArmandosProductShop.Models
{
    public class DataBase
    {
        /// <summary>
        /// A database represented as a list
        /// </summary>
        /// <returns></returns> 
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    ProductID = 1,
                    Name = "Product 1",
                    Price = (decimal) 499.00
                },
                new Product
                {
                    ProductID = 2,
                    Name = "Best Product Ever",
                    Price = (decimal) 1109.00
                },
                new Product
                {
                    ProductID = 3,
                    Name = "Third Product",
                    Price = (decimal) 2017.00
                },
                new Product
                {
                    ProductID = 4,
                    Name = "Worst Product Ever",
                    Price = (decimal) 3000.00
                },
                new Product
                {
                    ProductID = 5,
                    Name = "Buy this",
                    Price = (decimal) 1.00
                },
                new Product
                {
                    ProductID = 6,
                    Name = "Mystery Item",
                    Price = (decimal) 10.00
                },
                new Product
                {
                    ProductID = 7,
                    Name = "Product 7",
                    Price = (decimal) 7.00
                },
                new Product
                {
                    ProductID = 8,
                    Name = "Product of the Month",
                    Price = (decimal) 50.99
                },
                new Product
                {
                    ProductID = 9,
                    Name = "Product 9",
                    Price = (decimal) 9.99
                },
                new Product
                {
                    ProductID = 10,
                    Name = "Product 10",
                    Price = (decimal) 400.00
                },
            };
            return products;
        }

        public static Product GetProduct(string slug)
        {
            List<Product> products = DataBase.GetProducts();

            foreach(Product p in products)
            {
                if (p.Slug == slug)
                {
                    return p;
                }
            }
            return null;
        }
    }
}

