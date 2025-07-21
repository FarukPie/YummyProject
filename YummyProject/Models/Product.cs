using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string Ingredients { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public decimal Price { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }  //navigation property
    }
}