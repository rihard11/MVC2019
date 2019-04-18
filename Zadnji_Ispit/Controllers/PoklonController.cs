using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Zadnji_Ispit.Models;

namespace Zadnji_Ispit.Controllers
{
    public class PoklonController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Poklon
        public ActionResult Index()
        {
            List<Poklon> lPokloni = (from p in _db.Pokloni
                                     where p.Kupljeno == false 
                                     select p).ToList();

            return View(lPokloni);
        }

        public ActionResult ListaPoklona()
        {
            List<Poklon> lPokloni = (from p in _db.Pokloni
                                     select p).ToList();
            return View(lPokloni);
        }

        public ActionResult DodajPoklon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DodajPoklon(Poklon poklon)
        {
            if (ModelState.IsValid)
            {
                _db.Pokloni.Add(poklon);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(poklon);
        }

        public ActionResult UrediPoklon(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Poklon poklon = _db.Pokloni.Find(id);

            if (poklon == null)
            {
                return HttpNotFound();
            }

            return View(poklon);
        }

        [HttpPost]
        public ActionResult UrediPoklon(Poklon poklon)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(poklon).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(poklon);
        }

        public ActionResult Obrisi(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Poklon poklon = _db.Pokloni.Find(id);

            if (poklon == null)
            {
                return HttpNotFound();
            }
            return View(poklon);
        }

        [HttpPost, ActionName("Obrisi")]
        public ActionResult DeleteConfirmed(int id)
        {
            Poklon poklon = _db.Pokloni.Find(id);
            _db.Pokloni.Remove(poklon);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}