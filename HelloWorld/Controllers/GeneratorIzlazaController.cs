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
            // return Veew()
            return View();
        } 
    }
}