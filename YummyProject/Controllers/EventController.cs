using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;

namespace YummyProject.Controllers
{
    public class EventController : Controller
    {
            YummyContext context=new YummyContext();
        public ActionResult Index()
        {
            var value=context.Events.ToList();
            return View(value);
        }
    }
}