using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Product_Management_System.Models;

namespace Product_Management_System.Database_access_layer
{
    public class db
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Product"].ConnectionString);

        public void AddCustomer(RegistrationModel rg)
        {
            SqlCommand cmd = new SqlCommand("customer_add",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@firstname",rg.firstname);
            cmd.Parameters.AddWithValue("@lastname",rg.lastname);
            cmd.Parameters.AddWithValue("@city",rg.city);
            cmd.Parameters.AddWithValue("@state",rg.state);
            cmd.Parameters.AddWithValue("@country",rg.country);
            cmd.Parameters.AddWithValue("@email",rg.email);
            cmd.Parameters.AddWithValue("@password",rg.password);
            cmd.Parameters.AddWithValue("@mono",rg.mono);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public object LoginCredancial(LoginModel lg)
        {
             Logincradancial  l = new Logincradancial();
           
            SqlCommand cmd = new SqlCommand("Login_credancial", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", lg.email);
            cmd.Parameters.AddWithValue("@password", lg.password);
            con.Open();
            SqlDataReader rdr=cmd.ExecuteReader();
            if (rdr.Read())
            {
                
               
                l.firstname = rdr["firstname"].ToString();
                l.lastname = rdr["lastname"].ToString();
                l.id = Convert.ToInt32(rdr["userid"]);
                //HttpContext.Current.Session.Add("firstname", l.firstname);
                //HttpContext.Current.Session.Add("lastname", l.firstname);


            }
            return l;



        }

      
    }
}