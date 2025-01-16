using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;
using YummyProject.Models;

namespace YummyProject.Controllers
{
    public class FeatureController : Controller
    {
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            var value = context.Features.ToList();
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
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteFeature(int id)
        {
            var value = context.Features.Find(id);
            context.Features.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}