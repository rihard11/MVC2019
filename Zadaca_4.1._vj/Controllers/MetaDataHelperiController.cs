﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadaca_4._1._vj.Models;

namespace Zadaca_4._1._vj.Controllers
{
    public class MetaDataHelperiController : Controller
    {
        // GET: MetaDataHelperi
        public ViewResult  MetaDataView()
        {
            return View(new OsobaMeta());
        }

        [HttpPost]
        public ViewResult MetaDataView(OsobaMeta osoba)
        {
            return View("HtmlLabelDisplay", osoba);
        }
    }
}