using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Product_Management_System.Controllers
{
    public class LogoutController : Controller
    {
        // GET: Logout
        public ActionResult Index()
        {
            Session["firstname"] = null;
            Session["lastname"] = null;
            Session["id"] = null;
            return RedirectToAction("Index","Login");
        }
    }
}