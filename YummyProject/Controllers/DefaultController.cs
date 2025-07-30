using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;

namespace YummyProject.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        YummyContext context= new YummyContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult DefaultFeature()
        {
            var values=context.Features.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultAbout()
        {   
            var value=context.Abouts.ToList();
            return PartialView(value);
        }
        public PartialViewResult DefaultService()
        {
            var values=context.Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultStat()
        {
            ViewBag.TotalCategories = context.Categories.Count();
            ViewBag.TotalChefs = context.Chefs.Count();
            ViewBag.TotalDishes = context.Products.Count();
            ViewBag.AcceptedBookings = context.Bookings.Count(b => b.IsApproved == true);

            return PartialView();
        }
        public PartialViewResult DefaultProduct()
        {
            var values=context.Categories.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultTestimonial()
        {
            var values=context.Testimonials.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultEvent()
        {
            var values=context.Events.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultChef()
        {
            var value=context.Chefs.ToList();
            return PartialView(value);
        }
        public PartialViewResult DefaultBook()
        {
            return PartialView();
        }
        public PartialViewResult DefaultGallery()
        {
            var value=context.PhotoGalleries.ToList();
            return PartialView(value);
        }
        public PartialViewResult DefaultContact()
        {
            var value = context.ContactInfos.ToList();
            return PartialView(value);
        }
        public PartialViewResult DefaultMessage()
        {
            return PartialView();
        }
    }
}