using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;
namespace WebAppMVC.Controllers;

public class DemoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Message = "Hello from Demo Controller";
        var products = GetProducts();

        return View(products);
    }

public List<Product> GetProducts()
{
    return new List<Product>
    {
        new Product { Id = 1, Name = "Product 1", Description = "Description 1" },
        new Product { Id = 2, Name = "Product 2", Description = "Description 2" },
        new Product { Id = 3, Name = "Product 3", Description = "Description 3" },
        new Product { Id = 4, Name = "Product 4", Description = "Description 4" },
        new Product { Id = 5, Name = "Product 5", Description = "Description 5" }
    };
}
}





