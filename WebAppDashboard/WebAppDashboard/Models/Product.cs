using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppDashboard.Models
{
    public class Product
    {
        [Required(ErrorMessage ="required")]
        public int ProductId { get; set; }
        [Required]
        public String ProductName { get; set; }
        [Required]
        public String ProductImg { get; set; }
    }
}