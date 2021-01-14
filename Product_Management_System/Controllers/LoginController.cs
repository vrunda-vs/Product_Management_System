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
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            if (Session["firstname"] != null)
            {
                RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel loginmodel, Logincradancial lg)
        {
            if (Session["firstname"] != null)
            {
               return RedirectToAction("Index", "Home");
            }
            else
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Product"].ConnectionString);

                SqlCommand cmd = new SqlCommand("Login_credancial", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", loginmodel.email);
                cmd.Parameters.AddWithValue("@password", loginmodel.password);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {

                    Session["firstname"] = rdr["firstname"].ToString();
                    Session["lastname"] = rdr["lastname"].ToString();
                    Session["id"] = Convert.ToInt32(rdr["userid"]);
                    //HttpContext.Current.Session.Add("firstname", l.firstname);
                    //HttpContext.Current.Session.Add("lastname", l.firstname);


                }

                if (Session["firstname"] != null)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
                return View();


            }
        

       
    }
}