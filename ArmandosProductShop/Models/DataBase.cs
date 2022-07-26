using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                    ProductId = 1,
                    Name = "Product 1",
                    Price = (decimal) 499.00
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Best Product Ever",
                    Price = (decimal) 1109.00
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Third Product",
                    Price = (decimal) 2017.00
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Worst Product Ever",
                    Price = (decimal) 3000.00
                },
                new Product
                {
                    ProductId = 5,
                    Name = "Buy this",
                    Price = (decimal) 1.00
                },
                new Product
                {
                    ProductId = 6,
                    Name = "Mystery Item",
                    Price = (decimal) 10.00
                },
                new Product
                {
                    ProductId = 7,
                    Name = "Product 7",
                    Price = (decimal) 7.00
                },
                new Product
                {
                    ProductId = 8,
                    Name = "Product 8",
                    Price = (decimal) 50.99
                },
                new Product
                {
                    ProductId = 9,
                    Name = "Product 9",
                    Price = (decimal) 9.99
                },
                new Product
                {
                    ProductId = 10,
                    Name = "Product 10",
                    Price = (decimal) 400.00
                },
            };
            return products;
        }

        public static Product GetProduct(string slug)
        {
            List<Product> products = DataBase.GetProduct();

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

