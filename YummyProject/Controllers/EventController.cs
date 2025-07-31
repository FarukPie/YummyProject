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
    public class EventController : Controller
    {
            YummyContext context=new YummyContext();
        public ActionResult Index()
        {
            var value=context.Events.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult AddEvent()
        {
            return View();
        }
       [HttpPost]
        public ActionResult AddEvent(Event eventt)
        {
            if (!ModelState.IsValid)
            {
                return View(eventt);
            }

            context.Events.Add(eventt);
            int result = context.SaveChanges();
            if (result == 0)
            {
                ModelState.AddModelError("", "error");
                return View(eventt);
            }
            return RedirectToAction("Index");
        }
        public ActionResult DeleteEvent(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); // 400 Bad Request
            }

            var value = context.Events.Find(id);
            if (value == null)
            {
                return HttpNotFound(); // 404 Not Found
            }

            context.Events.Remove(value);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateEvent(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var about = context.Events.Find(id);
            if (about == null)
            {
                return HttpNotFound();
            }

            return View(about); // Mevcut veriyi view'a gönder
        }

        [HttpPost]

        public ActionResult UpdateEvent(Event eventt)
        {
            if (!ModelState.IsValid)
            {
                return View(eventt);
            }

            context.Entry(eventt).State = EntityState.Modified;
            int result = context.SaveChanges();

            if (result == 0)
            {
                ModelState.AddModelError("", "Güncelleme başarısız!");
                return View(eventt);
            }

            return RedirectToAction("Index");
        }




    }
}