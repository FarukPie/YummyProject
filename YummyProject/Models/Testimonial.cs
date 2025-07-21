using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string Title { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string Comment { get; set; }
        public int Rating { get; set; }
    }
}