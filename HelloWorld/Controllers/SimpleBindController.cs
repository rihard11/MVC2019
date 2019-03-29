using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class SimpleBindController : Controller
    {
        // GET: SimpleBind
        public ViewResult SimpleBindMetoda()
        {
            return View("SimpleBindMetoda");
        }
        // POST: SimpleBind
        [HttpPost]
        public ViewResult SimpleBindMetoda(string ime)
        {
            string pozdrav = "Pozdrav " + ime + "!";
            return View("SimpleBindMetoda", (object)pozdrav);
        }
    }
}