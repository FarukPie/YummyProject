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
    public class ServiceController : Controller
    {
       YummyContext context=new YummyContext();
        public ActionResult Index()
        {
            var value=context.Services.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddService(Service service)
        {
            if (!ModelState.IsValid)
            {
                return View(service);
            }

            context.Services.Add(service);
            int result = context.SaveChanges();
            if (result == 0)
            {
                ModelState.AddModelError("", "error");
                return View(service);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateService(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var about = context.Services.Find(id);
            if (about == null)
            {
                return HttpNotFound();
            }

            return View(about); // Mevcut veriyi view'a gönder
        }

        [HttpPost]

        public ActionResult UpdateService(Service service)
        {
            if (!ModelState.IsValid)
            {
                return View(service);
            }

            context.Entry(service).State = EntityState.Modified;
            int result = context.SaveChanges();

            if (result == 0)
            {
                ModelState.AddModelError("", "Güncelleme başarısız!");
                return View(service);
            }

            return RedirectToAction("Index");
        }
        public ActionResult DeleteService(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); // 400 Bad Request
            }

            var value = context.Services.Find(id);
            if (value == null)
            {
                return HttpNotFound(); // 404 Not Found
            }

            context.Services.Remove(value);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}