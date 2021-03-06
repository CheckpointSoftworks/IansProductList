using IansProductShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IansProductShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail(string slugLink)
        {
            Product product = Database.GetProduct(slugLink);
            return View(product);
        }

        public IActionResult List()
        {
            List<Product> products = Database.GetProducts();
            return View(products);
        }
    }
}
