using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Product_Management_System.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "FirstName Must Be Required")]
        [Display(Name = "FirstName")]
        public string firstname { get; set; }
        [Required(ErrorMessage = "LastName Must Be Required")]
        [Display(Name = "LastName")]
        public string lastname { get; set; }
        [Required(ErrorMessage = "City Must Be Required")]
        [Display(Name = "City")]
        public string city { get; set; }
        [Required(ErrorMessage = "State Must Be Required")]
        [Display(Name = "State")]
        public string state { get; set; }
        [Required(ErrorMessage = "Country Must Be Required")]
        [Display(Name = "Country")]
        public string country { get; set; }

        [Required(ErrorMessage = "Email Must Be Required")]
        [Display(Name = "Email")]

        public string email { get; set; }

        [Required(ErrorMessage = "Password Must Be Required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }
        [Required(ErrorMessage = "Mobil No Must Be Required")]
        [Display(Name = "Mobile no")]
        public string mono { get; set; }
    }
}