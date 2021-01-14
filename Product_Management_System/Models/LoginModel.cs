using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Product_Management_System.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Email Must Be Required")]
        [Display(Name = "Email")]

        public string email { get; set; }

        [Required(ErrorMessage = "Email Must Be Required")]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string password { get; set; }

    }
}