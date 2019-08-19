using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OkulProjesi.Data;
using OkulProjesi.Manager;

namespace OkulProjesi.Controllers
{
    public class AnaSayfaController : Controller
    {
        List<Duyurular> _Duyurular = new List<Duyurular>();
        MainPageService _Service = new MainPageManager();
        // GET: AnaSayfa
        public ActionResult AnaSayfa()
        {
            return View();
        }
    }
}