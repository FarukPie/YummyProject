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
       YummyContext context=new YummyContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult DefaultFeature()
        {   var value=context.Features.ToList();
            return PartialView(value);
        }

        public PartialViewResult DefaultAbout()
        {
            var value=context.Abouts.ToList();
            return PartialView(value);
        }
        public PartialViewResult DefaultService()
        {
            var value=context.Services.ToList();
            return PartialView(value);
        }

        public PartialViewResult DefaultProduct()
        {
            var value=context.categories.ToList();
            return PartialView(value);  
        }
        public PartialViewResult DefaultTestimonial()
        {
            var value=context.testimonials.ToList();
            return PartialView(value);

        }
    }
}