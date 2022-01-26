using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class Studentproductvm
    {
        public IEnumerable<Product> Products{ get; set; }
        public IEnumerable<Student> Students { get; set; }

    }
}
