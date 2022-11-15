using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(dbl_category category)
        {
            WebAppEntities1 db = new WebAppEntities1();
            db.dbl_category.Add(category);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult List()
        {
            WebAppEntities1 db = new WebAppEntities1();
            ViewBag.List = db.dbl_category.ToList();
            return View();
        }
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            WebAppEntities1 db = new WebAppEntities1();
            var category = db.dbl_category.Find(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(dbl_category category)
        {
            WebAppEntities1 db = new WebAppEntities1();
            db.dbl_category.AddOrUpdate(category);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult Delete(int id)
        {
            WebAppEntities1 db = new WebAppEntities1();
            var cat = db.dbl_category.Find(id);
            db.dbl_category.Remove(cat);
            db.SaveChanges();
            return RedirectToAction("List");
        }

    }
}