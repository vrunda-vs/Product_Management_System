using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Product_Management_System.Models;

namespace Product_Management_System.Controllers
{
   
    public class SaveDataController : ApiController
    {
        Database_access_layer.db dblayer = new Database_access_layer.db();
        [Route("api/values/AddCustomer/")]
        [HttpPost]
        public IHttpActionResult AddCustomer (RegistrationModel registrationmodel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                dblayer.AddCustomer(registrationmodel);
                return Ok("Success");
            }
            catch (Exception)
            {
                return Ok("Something went wrong");
            }
        }

        [Route("api/values/LoginCreadancial/")]
        [HttpPost]
        public IHttpActionResult LoginCredancial(LoginModel loginmodel)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                object obj = dblayer.LoginCredancial(loginmodel);
                
                return Ok(obj);
            }
            catch (Exception)
            {
                return Ok("Something went wrong");
            }
        }
    }
}
