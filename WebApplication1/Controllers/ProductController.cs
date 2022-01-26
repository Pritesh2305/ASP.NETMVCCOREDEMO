using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product{ code=1,name="PC",price=38000},
                new Product{ code=2,name="LAPTOP",price=58000},
                new Product{ code=3,name="MOBILE",price=48000},
            };

            Product prod = new Product();
            prod.code = 4;
            prod.name = "PEN DRIVE";
            prod.price = 500;
            products.Add(prod);

            List<Student> studentlist = new List<Student>()
            {
                new Student{ code=1,name="pritesh",email="bhavsarpritesh.mca@gmail.com" },
                new Student{ code=2,name="jay",email="jay.9@gmail.com" },
            };

            Studentproductvm stuprod = new Studentproductvm();
            stuprod.Students = studentlist;
            stuprod.Products = products;

            ViewBag.prod = prod;
            ViewBag.prodlist = products;

            return View(stuprod);
        }
    }
}
