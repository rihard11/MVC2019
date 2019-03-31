using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadaca_4._1._vj.Models;

namespace Zadaca_4._1._vj.Controllers
{
    public class NaruciArtikalController : Controller
    {
        // GET: NaruciArtikal
        public ViewResult NaruciArtikal()
        {
            return View(new Artikl());
        }

        // POST
        [HttpPost]
        public ViewResult NaruciArtikal(Artikl artikal)
        {
            if (artikal.Kolicina > 10)
            {
                ViewBag.Poruka = "Nema dovoljno " + artikal.Naziv + " na skladištu!";
                return View(artikal);
            }
            else
            {
                ViewBag.Poruka = "Naručeno je " +
                    artikal.Kolicina +
                    " komad/a " +
                    artikal.Naziv +
                    " sa ukupnom cijenom " +
                    artikal.Cijena * artikal.Kolicina +
                    " HRK.";
                return View(artikal);
            }
        }
    }
}