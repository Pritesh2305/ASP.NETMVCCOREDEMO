using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    public class UserCController : Controller
    {
        Context _objcontext;

        public UserCController(Context objcontext)
        {
            _objcontext = objcontext;
        }

        public IActionResult Index()
        {
          List<User> userlist1 = _objcontext.Users.FromSqlInterpolated($"select * from users").ToList();
            
            int id = 4;
            var author = _objcontext.Users.FromSqlInterpolated($"SELECT * From users Where Id = {id}").FirstOrDefault();

            List<User> userlist2 = _objcontext.Users.FromSqlInterpolated($"EXEC USP_USERSLIST").ToList();

            List<User> userlist3 = _objcontext.Users.FromSqlInterpolated($"EXEC USP_USERSLIST_PARA @id={id}").ToList();

            IEnumerable<User> userlist = _objcontext.Users.ToList().DefaultIfEmpty();

            if (userlist.Count() > 0)
            {
                return View(userlist);
            }
            else
            {
                return View();
            }
            
        }

        public IActionResult Create()
        {
            User user = new User();

            return View(user);
        }
        [HttpPost]
        public IActionResult Create(User objuser)
        {
            if (ModelState.IsValid)
            {
                _objcontext.Users.Add(objuser);
                _objcontext.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Delete(int id,string name)
        {
             User obj = _objcontext.Users.Find(id);
            _objcontext.Users.Remove(obj);
            _objcontext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            User obj = _objcontext.Users.Find(id);

            if (obj.Id != 0)
            {
                return View(obj);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Update(User objuser)
        {
            User obj = _objcontext.Users.Find(objuser.Id);

            if (obj.Id != 0)
            {
                obj.Name = objuser.Name;
                obj.DOB = objuser.DOB;
                obj.MobileNo = objuser.MobileNo;
                obj.EmailId = objuser.EmailId;
                obj.Address = objuser.Address;
                obj.City = objuser.City;                
            }
            _objcontext.Update(obj);
            _objcontext.SaveChanges();
           return RedirectToAction("Index");            
        }
    }
}
