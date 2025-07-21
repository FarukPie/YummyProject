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
    public class CategoryController : Controller
    {
        YummyContext context=new YummyContext();
        public ActionResult Index()
        {
            var value=context.Categories.ToList();
            return View(value);
        }
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            context.Categories.Add(category);
            int result = context.SaveChanges();
            if (result == 0)
            {
                ModelState.AddModelError("", "error");
                return View(category);
            }
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCategory(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); // 400 Bad Request
            }

            var value = context.Categories.Find(id);
            if (value == null)
            {
                return HttpNotFound(); // 404 Not Found
            }

            context.Categories.Remove(value);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}