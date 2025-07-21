using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string CategoryName { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}