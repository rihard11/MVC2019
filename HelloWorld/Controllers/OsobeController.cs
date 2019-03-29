using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class OsobeController : Controller
    {
        // GET: Osoba
        public ActionResult PopuniOsobu()
        {
            return View();
        }
        // POST: Osoba/PrikaziOsobu
        [HttpPost]
        public ViewResult PrikaziOsobu(Osoba osoba)
        {
            return View(osoba);
        }
    }
}