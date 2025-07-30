using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;

namespace YummyProject.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        YummyContext context=new YummyContext();
        public ActionResult Index()
        {
            ViewBag.soupCount = context.Products.Count(x => x.Category.CategoryName == "Soups");
            ViewBag.mostExpensive=context.Products.OrderByDescending(x=>x.Price).Select(x=>x.ProductName).FirstOrDefault();
            ViewBag.avgPrice=context.Products.Average(x=>x.Price);
            ViewBag.cheapestPrice = context.Products.OrderBy(x => x.Price).Select(x => x.ProductName).FirstOrDefault();
            var acceptedBookings = context.Bookings
                                    .Where(b => b.IsApproved == true)
                                    .ToList();

            return View(acceptedBookings);
        }
    }
}