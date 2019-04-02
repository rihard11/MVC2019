using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadaca_4._1._vj.Models;

namespace Zadaca_4._1._vj.Controllers
{
    public class ParcijalniPogledController : Controller
    {
        // GET: ParcijalniPogled
        public ActionResult PrikaziKosaricu()
        {
            List<Artikl> ListaArtikala = new List<Artikl>()
            {
                new Artikl() {Cijena=9.99m, Kategorija="plava", Kolicina=5, Naziv="Keks"},
                new Artikl() {Cijena=8.99m, Kategorija="zelena", Kolicina=7, Naziv="Kifla"},
                new Artikl() {Cijena=5.99m, Kategorija="zuta", Kolicina=520, Naziv="Kroki"}
            };
            return View(ListaArtikala);
        }
    }
}