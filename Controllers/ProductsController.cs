
using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductsController : Controller
    {
        // Temporary product storage
        private static List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Description = "High performance laptop",
                Price = 55000,
                Category = "Electronics"
            },
            new Product
            {
                Id = 2,
                Name = "Headphones",
                Description = "Wireless headphones",
                Price = 2500,
                Category = "Accessories"
            }
        };

        // Display all products
        public IActionResult Index()
        {
            return View(products);
        }
    }
}
