﻿using System;
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
        public string RoutePodaci()
        {
            try
            {
                string kontroler = RouteData.Values["controller"].ToString();
                string akcijskaMetoda = RouteData.Values["action"].ToString();
                string parametarId = RouteData.Values["id"].ToString();
                return "<h1>Route podaci:</h1>" +
                    "Kontroler: " + kontroler + "<br />" +
                    "Metoda: " + akcijskaMetoda + "<br />" +
                    "Parametar id: " + parametarId + "<br />";
            }
            catch (Exception ex)
            {
                return "Došlo je do pogreške: " + ex.Message;
            }
        }
    }
}