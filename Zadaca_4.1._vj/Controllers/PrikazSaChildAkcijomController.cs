using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadaca_4._1._vj.Models;

namespace Zadaca_4._1._vj.Controllers
{
    public class PrikazSaChildAkcijomController : Controller
    {
        // GET: PrikazSaChildAkcijom
        public ActionResult ObradiListu()
        {
            List<Artikl> artikli = new List<Artikl>()
            {
                new Artikl()
                {
                    Naziv = "Lonac", Cijena = 229.90m, Kategorija = "Kucne potrepstine"
                },
                new Artikl()
                {
                    Naziv = "Skije", Cijena = 1100, Kategorija = "Sport"
                },
                new Artikl()
                {
                    Naziv = "Salama", Cijena = 35.50m, Kategorija = "Hrana"
                }
            };
            return View(artikli);
        }

        // Child Akcija
        [ChildActionOnly]
        public string OdrediKategoriju(Artikl artikl)
        {
            return artikl.Kategorija;
        }
    }
}