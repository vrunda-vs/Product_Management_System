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
    public class ViewProductController : Controller
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Product"].ConnectionString);

        // GET: ViewProduct
        public ActionResult Index()
        {
            if (Session["firstname"] == null)
            {
               return RedirectToAction("Index", "Login");
            }
            SqlCommand cmd = new SqlCommand("viewdata", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return View(dt);
          
        }

       
        public ActionResult search()
        {
            string search= Request.QueryString["search"];
            if (search.Equals("Product Name"))
            {
                search = "product_name";
            }
            else if (search.Equals("Product category"))
            {   
                search = "category";
            }
            else {
                search = "price";
            }
            SqlCommand cmd = new SqlCommand("select * from product_details order by '"+ search +"' ASC", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return View(dt);

        }
    }
}