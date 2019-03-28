using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2._01_vjezba.Controllers
{
    public class Home1Controller : Controller
    {
        // GET: Home1
        public ActionResult Index()
        {
            string message = "Rezultat operacije 4 + 3 * 3 = ";
            return View((object)message);

        }
    }
}