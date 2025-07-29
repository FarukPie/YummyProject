using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;
using YummyProject.Models;

namespace YummyProject.Controllers
{
    public class ChefController : Controller
    {
        YummyContext context=new YummyContext();
        public ActionResult Index()
        {
            var value=context.Chefs.ToList();
            return View(value);
        }
        public ActionResult AddChef()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddChef(Chef chef)
        {
            if (!ModelState.IsValid)
            {
                return View(chef);
            }

            context.Chefs.Add(chef);
            int result = context.SaveChanges();
            if (result == 0)
            {
                ModelState.AddModelError("", "error");
                return View(chef);
            }
            return RedirectToAction("Index");

        }
        public ActionResult DeleteChef(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); // 400 Bad Request
            }

            var value = context.Chefs.Find(id);
            if (value == null)
            {
                return HttpNotFound(); // 404 Not Found
            }

            context.Chefs.Remove(value);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateChef(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var category = context.Chefs.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }

            return View(category); // Mevcut veriyi view'a gönder
        }

        [HttpPost]

        public ActionResult UpdateChef(Chef chef)
        {
            if (!ModelState.IsValid)
            {
                return View(chef);
            }

            context.Entry(chef).State = EntityState.Modified;
            int result = context.SaveChanges();

            if (result == 0)
            {
                ModelState.AddModelError("", "Güncelleme başarısız!");
                return View(chef);
            }

            return RedirectToAction("Index");
        }
    }
}