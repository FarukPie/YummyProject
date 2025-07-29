using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;

namespace YummyProject.Controllers
{
    [AllowAnonymous]
    public class UILayoutController : Controller
    {
        YummyContext context=new YummyContext();
        // GET: UILayout
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult SocaiMedias()
        {
            var value =context.SocialMedias.ToList();
            return PartialView(value);
        }
        public PartialViewResult ContactUs()
        {
            var value=context.ContactInfos.ToList();
            return PartialView(value);
        }
    }
}