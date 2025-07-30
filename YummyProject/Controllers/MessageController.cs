using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;
using YummyProject.Models;

namespace YummyProject.Controllers
{
    public class MessageController : Controller
    {

        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            var messages = context.Messages.OrderByDescending(x => x.MessageID).ToList();
            return View(messages); // View'e mesaj listesini gönderiyoruz
        }

        [HttpPost]
        public ActionResult Create(Message message)
        {
            if (ModelState.IsValid)
            {
                message.IsRead = false;
                context.Messages.Add(message);
                context.SaveChanges();
                TempData["Success"] = "Mesaj başarıyla gönderildi.";
                return RedirectToAction("Index");
            }

            TempData["Error"] = "Mesaj gönderilirken hata oluştu. Lütfen tüm alanları doldurun.";
            return RedirectToAction("Index");
        }
        public ActionResult MarkAsRead(int id)
        {
            var message = context.Messages.Find(id);
            if (message != null)
            {
                message.IsRead = true;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var message = context.Messages.Find(id);
            if (message != null)
            {
                context.Messages.Remove(message);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }



    }
}