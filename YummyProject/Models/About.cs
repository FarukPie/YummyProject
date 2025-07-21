using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class About
    {
        public int AboutID { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string ImageUrl1 { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string ImageUrl2 { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string TopDescription { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string Item1 { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string Item2 { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string Item3 { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string VideoUrl { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string PhoneNumber { get; set; }

    }
}