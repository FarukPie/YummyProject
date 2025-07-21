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

        [Required(ErrorMessage ="image Url is not be empty")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Title is not be empty")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is not be empty")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Video Url is not be empty")]
        public string VideoUrl { get; set; }
    }
}