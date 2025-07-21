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
    public class FeatureController : Controller
    {
        YummyContext context=new YummyContext();
        public ActionResult Index()
        {
            var value=context.Features.ToList();
            return View(value);
        }
        public ActionResult AddFeature()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFeature(Feature feature)
        {
            if(!ModelState.IsValid)
            {
                return View(feature);
            }

            context.Features.Add(feature);
            int result=context.SaveChanges();
            if(result==0)
            {
                ModelState.AddModelError("","error");
                return View(feature);
            }
            return RedirectToAction("Index");

        }
        public ActionResult DeleteFeature(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); // 400 Bad Request
            }

            var value = context.Features.Find(id);
            if (value == null)
            {
                return HttpNotFound(); // 404 Not Found
            }

            context.Features.Remove(value);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}