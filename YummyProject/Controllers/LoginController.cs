using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Models;
using YummyProject.Context;
using System.Web.Security;

namespace YummyProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        YummyContext context = new YummyContext();
        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(Admin model)
        {

            var admin = context.Admins.FirstOrDefault(x => x.UserName == model.UserName && x.Password == model.Password);
            if (admin == null)
            {
                ModelState.AddModelError("", "Kullanıcı adı ya da şifre hatalı");
                return View(model);

            }
            FormsAuthentication.SetAuthCookie(admin.UserName, false);
            Session["currentUser"] = admin.UserName;
            return RedirectToAction("Index", "Dashboard");
        }
    }
}