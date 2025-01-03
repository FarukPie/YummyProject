using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using YummyProject.Models;

namespace YummyProject.Context
{
    public class YummyContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<ChefSocial> ChefSocials { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<PhotoGallery> photoGalleries { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> testimonials { get; set; }


    }
}