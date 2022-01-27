using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace WebApplication1.Controllers
{
    public class UserQController : Controller
    {

        private IConfiguration configuration;
        string dbConnstr = "";
        public UserQController(IConfiguration iconfig)
        {
            configuration = iconfig;
            dbConnstr = configuration.GetSection("ConnectionStrings").GetSection("Testdb").Value;
        }        

        public IActionResult Index()
        {
            SqlConnection con = new SqlConnection(dbConnstr);
            
            if(con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }




            return View();
        }
    }
}
