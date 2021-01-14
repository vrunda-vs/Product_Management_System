using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Product_Management_System.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Product_Management_System.Controllers
{
    public class AddProductController : Controller
    {
        // GET: AddProduct
        public ActionResult Index()
        {
            if (Session["firstname"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Index(AddProduct addproduct, HttpPostedFileBase smallimage,HttpPostedFileBase largeimage)
        {
            if (Session["firstname"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            string filename_smallimage = "small" + Session["id"]+System.IO.Path.GetFileName(smallimage.FileName);
            string fullpath_smallimage = Server.MapPath("~/Images/") +  filename_smallimage ;
            smallimage.SaveAs(fullpath_smallimage);

            string filename_largeimage = "large" + Session["id"] + System.IO.Path.GetFileName(largeimage.FileName);
            string fullpath_largeimage = Server.MapPath("~/Images/") + filename_largeimage ;
            largeimage.SaveAs(fullpath_largeimage);

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Product"].ConnectionString);
            SqlCommand cmd = new SqlCommand("product_add_details", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userid",1);
            cmd.Parameters.AddWithValue("@product_name",addproduct.name);
            cmd.Parameters.AddWithValue("@category",addproduct.category);
            cmd.Parameters.AddWithValue("@price",addproduct.price);
            cmd.Parameters.AddWithValue("@quality",addproduct.quantity);
            cmd.Parameters.AddWithValue("@short_description",addproduct.short_description);
            cmd.Parameters.AddWithValue("@long_description",addproduct.long_description);
            cmd.Parameters.AddWithValue("@small_img", filename_smallimage);
            cmd.Parameters.AddWithValue("@large_img", filename_largeimage);
            con.Open();
            int i=cmd.ExecuteNonQuery();
            if (i > 0)
            {
                return RedirectToAction("Index", "ViewProduct");
            }
            con.Close();

            return View();
        }
    }
}