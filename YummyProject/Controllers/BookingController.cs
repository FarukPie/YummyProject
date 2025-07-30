using System;
using System.Linq;
using System.Web.Mvc;
using YummyProject.Context;
using YummyProject.Models;

namespace YummyProject.Controllers
{
    public class BookingController : Controller
    {
        private readonly YummyContext context = new YummyContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Booking booking)
        {
            if (booking.BookingDate == DateTime.MinValue)
            {
                booking.BookingDate = DateTime.Now;
            }

            if (ModelState.IsValid)
            {
                booking.IsApproved = false; // Yeni eklenen rezervasyon beklemede
                context.Bookings.Add(booking);
                context.SaveChanges();
                return RedirectToAction("Index", "Default");
            }
            return RedirectToAction("Index", "Default");
        }

        public ActionResult Pending()
        {
            var pendingBookings = context.Bookings.Where(b => b.IsApproved == false).ToList();
            return View(pendingBookings);
        }

        public ActionResult Accepted()
        {
            var acceptedBookings = context.Bookings.Where(b => b.IsApproved == true).ToList();
            return View(acceptedBookings);
        }

        [HttpPost]
        public ActionResult Accept(int id)
        {
            var booking = context.Bookings.Find(id);
            if (booking != null)
            {
                booking.IsApproved = true;
                context.SaveChanges();
            }
            return RedirectToAction("Pending");
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var booking = context.Bookings.Find(id);
            if (booking != null)
            {
                context.Bookings.Remove(booking);
                context.SaveChanges();
            }
            return RedirectToAction("Pending");
        }
    }
}
