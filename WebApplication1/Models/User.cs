using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]        
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is Required.")]
        [Display(Name ="Enter Name")]
        public string Name { get; set; }

        public DateTime DOB { get; set; }

        public string MobileNo { get; set; }

        [EmailAddress(ErrorMessage ="Enter Valid E-Mail Address !")]     
        public string EmailId { get; set; }

        public string Address { get; set; }

        public string City { get; set; }


    }
}
