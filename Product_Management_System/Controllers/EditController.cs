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
    public class EditController : Controller
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Product"].ConnectionString);

       
        // GET: Edit
        public ActionResult Index(int ? id)
        {
            Editproduct es = new Editproduct();
            if (Session["firstname"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            SqlCommand cmd = new SqlCommand("select product_name,category,price,quantity,short_description,long_description from product_details where product_id='"+id+"'", con);
            
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {


                es.name = rdr["product_name"].ToString();
                es.category = rdr["category"].ToString();
                es.price = Convert.ToInt32(rdr["price"]);
                es.quantity = Convert.ToInt32(rdr["quantity"]);
                es.short_description = rdr["short_description"].ToString();
                es.long_description = rdr["long_description"].ToString();



                //HttpContext.Current.Session.Add("firstname", l.firstname);
                //HttpContext.Current.Session.Add("lastname", l.firstname);


            }
         
           
            return View(es);
        }
        [HttpPost]
        public ActionResult Index(Editproduct es, int? id)
        {
            if (Session["firstname"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
          

            SqlCommand cmd = new SqlCommand("EditProduct", con);
           
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@product_id",id);
            cmd.Parameters.AddWithValue("@product_name", es.name);
            cmd.Parameters.AddWithValue("@category", es.category);
            cmd.Parameters.AddWithValue("@price", es.price);
            cmd.Parameters.AddWithValue("@quantity", es.quantity);
            cmd.Parameters.AddWithValue("@short_des", es.short_description);
            cmd.Parameters.AddWithValue("@long_des", es.long_description);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                return RedirectToAction("Index", "ViewProduct");
            }

            con.Close();
            return View();

          
          
        }
    }
}