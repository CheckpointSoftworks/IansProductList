using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IansProductShop.Models
{
    public class Database
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    Name = "Product 1",
                    Price = (decimal) 499.00
                },
                new Product
                {
                    ProductID = 2,
                    Name = "Best product ever",
                    Price = (decimal) 1109.00
                },
                new Product
                {
                    ProductID = 3,
                    Name = "Third product",
                    Price = (decimal) 358.00
                },
                new Product
                {
                    ProductID = 4,
                    Name = "Product of the month",
                    Price = (decimal) 555.67
                }
                ,
                new Product
                {
                    ProductID = 5,
                    Name = "Fifth product",
                    Price = (decimal) 245.00
                }
                ,
                new Product
                {
                    ProductID = 6,
                    Name = "Best product ever",
                    Price = (decimal) 765.00
                }
                ,
                new Product
                {
                    ProductID = 7,
                    Name = "Seventh product",
                    Price = (decimal) 876.00
                }
                ,
                new Product
                {
                    ProductID = 8,
                    Name = "Eighth product",
                    Price = (decimal) 234.00
                }
                ,
                new Product
                {
                    ProductID = 9,
                    Name = "Ninth Product",
                    Price = (decimal) 550.00
                }
                ,
                new Product
                {
                    ProductID = 10,
                    Name = "Tenth product",
                    Price = (decimal) 654.00
                }
            };
            return products;
        }

        public static Product GetProduct(string slug)
        {
            List<Product> products = Database.GetProducts();
            foreach(Product p in products)
            {
                if (string.Equals(p.Slug,slug))
                {
                    return p;
                }
            }
            return null;
        }
    }
}
