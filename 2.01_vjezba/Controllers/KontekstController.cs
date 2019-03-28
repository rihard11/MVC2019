using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2._01_vjezba.Controllers
{
    public class KontekstController : Controller
    {
        // GET: Kontekst
        public string Index()
        {
            // return View();
            string poruka = "Danas je: " + DateTime.Now.ToLongDateString();
            return poruka;
        }  
        public string QuerryPodaci ()
        {
            if (Request.QueryString["Ime"] == null || Request.QueryString["Prezime"] == null)
            {
                return "Podaci su nepotpuni";
            }
            else
            {
                string Ime = Request.QueryString["Ime"];
                string Prezime = Request.QueryString["Prezime"];
                string textSaStilom = string.Format("<label style= 'color: red; font-weight: bold;'>{0} {1}</label>", Ime, Prezime);
                return string.Format("<p>Ime i prezime iz query stringa su: {0}</p>", textSaStilom);
            }
        }
    }
}