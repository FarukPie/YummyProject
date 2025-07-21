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
    }
}