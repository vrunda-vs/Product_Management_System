using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Product_Management_System.Controllers
{
    public class DeleteController : Controller
    {
        // GET: Delete
        
        public ActionResult Index(int ? id)
        {
            if (Session["firstname"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Product"].ConnectionString);
            SqlCommand cmd = new SqlCommand("delete from product_details where product_id='" + id+"'", con);
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