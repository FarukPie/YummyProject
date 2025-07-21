using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class ContactInfo
    {
        public int ContactInfoID { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string Address { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string MapUrl { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string OpenHours { get; set; }
    }
}