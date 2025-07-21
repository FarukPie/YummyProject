using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class PhotoGallery
    {
        public int PhotoGalleryID { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string ImageUrl { get; set; }
    }
}