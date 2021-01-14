using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Product_Management_System.Models
{
    public class AddProduct
    {
      
        [Required]
        [Display(Name ="Product Name")]
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


        [Required]
        [Display(Name = "Product Small Image")]
        public HttpPostedFileBase small_img { get; set; }
        [Required]
        [Display(Name = "Product Large Image")]
        public string large_img { get; set; }





    }
}