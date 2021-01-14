using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Product_Management_System.Models
{
    public class Editproduct
    {
        [Required]
        [Display(Name = "Product Name")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Product Category")]
        public string category { get; set; }

        [Required]
        [Display(Name = "Product Price")]
        public int price { get; set; }
        [Required]
        [Display(Name = "Product Quantity")]
        public int quantity { get; set; }
        [Required]
        [Display(Name = "Product Short_Description")]
        public string short_description { get; set; }
        [Required]
        [Display(Name = "Product Long_Description")]
        public string long_description { get; set; }

    }
}