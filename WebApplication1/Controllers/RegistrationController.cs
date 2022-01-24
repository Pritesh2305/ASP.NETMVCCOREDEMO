using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index(int id,string name)
        {
            int idget = id;
            string name1 = name;
            return View();
        }

        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
