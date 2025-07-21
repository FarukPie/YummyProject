using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;
using YummyProject.Models;

namespace YummyProject.Controllers
{
    public class AboutController : Controller
    {
        YummyContext context=new YummyContext();
        public ActionResult Index()
        {
            var value=context.Abouts.ToList();
            return View(value);
        }
        public ActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAbout(About about)
        {
            if (!ModelState.IsValid)
            {
                return View(about);
            }

            context.Abouts.Add(about);
            int result = context.SaveChanges();
            if (result == 0)
            {
                ModelState.AddModelError("", "error");
                return View(about);
            }
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAbout(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); // 400 Bad Request
            }

            var value = context.Abouts.Find(id);
            if (value == null)
            {
                return HttpNotFound(); // 404 Not Found
            }

            context.Abouts.Remove(value);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}