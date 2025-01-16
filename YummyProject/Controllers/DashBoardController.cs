using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;

namespace YummyProject.Controllers
{
    public class DashBoardController : Controller
    {
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            ViewBag.soupCount = context.products.Count(x => x.Category.CategoryName == "Çorbalar");
            ViewBag.mostExpensive = context.products.OrderByDescending(x => x.Price).Select(x => x.ProductName).FirstOrDefault();
            ViewBag.avgPrice = context.products.Average(x => x.Price);
            ViewBag.cheapestPrice = context.products.OrderBy(x => x.Price).Select(x => x.ProductName).FirstOrDefault();
            return View();
        }
    }
}