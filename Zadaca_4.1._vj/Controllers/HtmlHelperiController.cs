using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadaca_4._1._vj.Models;

namespace Zadaca_4._1._vj.Controllers
{
    public class HtmlHelperiController : Controller
    {
        // GET: HtmlHelperi
        public ActionResult Index()
        {
            return View();
        }

        private string[] mjesta = new string[]
        {
            "Split", "Osijek", "Zadar", "Rijeka"
        };

        public ViewResult StrongTypedFormHelper()
        {
            ViewBag.Mjesta = this.mjesta;
            return View(new Osoba());
        }
        [HttpPost]
        public ViewResult StrongTypedFormHelper(Osoba osoba)
        {
            ViewBag.Mjesta = this.mjesta;
            ViewBag.Poruka = "Unešeni su podaci";
            return View(new Osoba());
        }
    }
}