using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            User objuser = new User();
            return View(objuser);
        }


        [HttpPost]
        public IActionResult Index(User objuser)
        {
            if (ModelState.IsValid)
            {
                ViewBag.sms = "Save Sucessfull";                
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.sms = "Not Save Sucessfull";
                return View();
            }
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
