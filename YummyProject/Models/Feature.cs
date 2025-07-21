using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class Feature
    {
        public int FeatureID { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string Title { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string VideoUrl { get; set; }
    }
}