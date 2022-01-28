using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [Table("UserProfile")]
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        [Required]
        
        [Column("Name",TypeName="nvarchar(200)")]
        [StringLength(10,ErrorMessage ="Name 10 Characted Only")]
        public string Name { get; set; }

        [MinLength(10,ErrorMessage ="Please Enter Valid Mobile No")]
        [Column("MobileNo", TypeName = "nvarchar(50)")]
        public string  MobileNo { get; set; }

        [Column("Address1",TypeName ="nvarchar(max)")]
        public string AddressLine1 { get; set; }

        [Column("Address2", TypeName = "nvarchar(max)")]
        public string AddressLine2 { get; set; }

        [NotMapped]
        public string FullName { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
