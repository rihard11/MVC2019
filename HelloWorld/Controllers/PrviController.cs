using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class PrviController : Controller
    {
        // GET: Prvi/MetodeSParametrima/1349
        public ActionResult MetodeSParametrima(int id)
        {
            // return View();
            return Content(id.ToString());
        }
        // GET: Drugi/DrugaMetodeSParametrima/54321
        public ViewResult DrugaMetodeSParametrima(int id)
        {
            return View((object)id);
            // return Content(id.ToString());
        }
    }
}