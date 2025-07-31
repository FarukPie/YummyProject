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
    public class PhotoGalleryController : Controller
    {
        YummyContext context=new YummyContext();
        public ActionResult Index()
        {
            var value=context.PhotoGalleries.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult AddPhoto()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPhoto(PhotoGallery photo)
        {
            if (!ModelState.IsValid)
            {
                return View(photo);
            }

            context.PhotoGalleries.Add(photo);
            int result = context.SaveChanges();
            if (result == 0)
            {
                ModelState.AddModelError("", "error");
                return View(photo);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdatePhoto(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var about = context.PhotoGalleries.Find(id);
            if (about == null)
            {
                return HttpNotFound();
            }

            return View(about); // Mevcut veriyi view'a gönder
        }

        [HttpPost]

        public ActionResult UpdatePhoto(PhotoGallery photo)
        {
            if (!ModelState.IsValid)
            {
                return View(photo);
            }

            context.Entry(photo).State = EntityState.Modified;
            int result = context.SaveChanges();

            if (result == 0)
            {
                ModelState.AddModelError("", "Güncelleme başarısız!");
                return View(photo);
            }

            return RedirectToAction("Index");
        }
        public ActionResult DeletePhoto(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); // 400 Bad Request
            }

            var value = context.PhotoGalleries.Find(id);
            if (value == null)
            {
                return HttpNotFound(); // 404 Not Found
            }

            context.PhotoGalleries.Remove(value);
            context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}