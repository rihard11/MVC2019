﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zadaca_4._1._vj.Controllers
{
    public class TocanOdgovorController : Controller
    {
        // GET: TocanOdgovor
        public ViewResult ProvjeriOdgovor()
        {
            return View();
        }

        // POST: TocanOdgovor/ProvjeriOdgovor
        [HttpPost]
        public ViewResult ProvjeriOdgovor(string odgovor)
        {
            string rezultat;
            if (!string.IsNullOrEmpty(odgovor))
            {
                if (odgovor == "Bruxelles")
                {
                    rezultat = "Odgovor je točan!";
                    return View((object)rezultat);
                }
                else
                {
                    rezultat = "Odgovor nije točan!";
                    return View((object)rezultat);
                }

            }
            else
            {
                rezultat = "Odgovor ne postoji!";
                return View((object)rezultat);
            }
        }
    }
}