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
        List<Duyurular> _Duyurular = new List<Duyurular>().ToList();
        List<AlinanDersler> _AlinanDersler = new List<AlinanDersler>();
        List<Lesson> _Lesson = new List<Lesson>();
        List<Student> _Student = new List<Student>();
        List<Teacher> _Teacher = new List<Teacher>();
        List<Yoklama> _Yoklama = new List<Yoklama>();

        MainPageService _Service = new MainPageManager();
        // GET: AnaSayfa
        public ActionResult AnaSayfa()
        {
            return View(_Duyurular);
        }
    }
}