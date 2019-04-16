using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class WebShopController : Controller
    {
        private WebshopEntities db = new WebshopEntities();

        // GET: WebShop
        public ActionResult Index()
        {
            var proizvodi = db.Proizvodis.Include(p => p.MjereProizvoda);
            return View(proizvodi.ToList());
        }
    }
}