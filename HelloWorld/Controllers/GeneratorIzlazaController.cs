using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class GeneratorIzlazaController : Controller
    {
        // GET: GeneratorIzlaza/PopisKosarice
        public ActionResult PopisKosarice()
        {
            return View();
        }
        // GET: GeneratorIzlaza/ListaArtikala
        public ActionResult ListaArtikala()
        {
            string[] lista = new string[] { "Skije", "Pancerice", "Naocale", "Kape", "Stapovi" };
            ViewBag.Lista = lista;
            return View();
        }

        // GeneratorIzlaza/RedirectNaMetodu/Kosarica
        public ActionResult RedirectNaMetodu(string id)
        {
            if (id == "Kosarica")
            {
                return RedirectToAction("PopisKosarice");
            }
            // GeneratorIzlaza/RedirectNaMetodu/hello
            else if (id == "hello")
            {
                return RedirectToAction("Index", "PozdravSvijete");
            }
            else if (id == "2")
            {
                return RedirectToAction("Kvadriraj", "Home1Controller", new {id = id });
            }
            // GeneratorIzlaza/RedirectNaMetodu/ListaArtikala
            else
            {
                return RedirectToAction("ListaArtikala");
            }
        }
    }
}