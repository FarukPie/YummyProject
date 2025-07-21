namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "ImageUrl1", c => c.String(nullable: false));
            AlterColumn("dbo.Abouts", "ImageUrl2", c => c.String(nullable: false));
            AlterColumn("dbo.Abouts", "TopDescription", c => c.String(nullable: false));
            AlterColumn("dbo.Abouts", "Item1", c => c.String(nullable: false));
            AlterColumn("dbo.Abouts", "Item2", c => c.String(nullable: false));
            AlterColumn("dbo.Abouts", "Item3", c => c.String(nullable: false));
            AlterColumn("dbo.Abouts", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Abouts", "VideoUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Abouts", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "ImageUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Ingredients", c => c.String(nullable: false));
            AlterColumn("dbo.Chefs", "ImageUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Chefs", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Chefs", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Chefs", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.ContactInfoes", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.ContactInfoes", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.ContactInfoes", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.ContactInfoes", "MapUrl", c => c.String(nullable: false));
            AlterColumn("dbo.ContactInfoes", "OpenHours", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "ImageUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.PhotoGalleries", "ImageUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Services", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Services", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Services", "Icon", c => c.String(nullable: false));
            AlterColumn("dbo.Testimonials", "ImageUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Testimonials", "NameSurname", c => c.String(nullable: false));
            AlterColumn("dbo.Testimonials", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Testimonials", "Comment", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Testimonials", "Comment", c => c.String());
            AlterColumn("dbo.Testimonials", "Title", c => c.String());
            AlterColumn("dbo.Testimonials", "NameSurname", c => c.String());
            AlterColumn("dbo.Testimonials", "ImageUrl", c => c.String());
            AlterColumn("dbo.Services", "Icon", c => c.String());
            AlterColumn("dbo.Services", "Description", c => c.String());
            AlterColumn("dbo.Services", "Title", c => c.String());
            AlterColumn("dbo.PhotoGalleries", "ImageUrl", c => c.String());
            AlterColumn("dbo.Events", "Description", c => c.String());
            AlterColumn("dbo.Events", "Title", c => c.String());
            AlterColumn("dbo.Events", "ImageUrl", c => c.String());
            AlterColumn("dbo.ContactInfoes", "OpenHours", c => c.String());
            AlterColumn("dbo.ContactInfoes", "MapUrl", c => c.String());
            AlterColumn("dbo.ContactInfoes", "PhoneNumber", c => c.String());
            AlterColumn("dbo.ContactInfoes", "Email", c => c.String());
            AlterColumn("dbo.ContactInfoes", "Address", c => c.String());
            AlterColumn("dbo.Chefs", "Description", c => c.String());
            AlterColumn("dbo.Chefs", "Title", c => c.String());
            AlterColumn("dbo.Chefs", "Name", c => c.String());
            AlterColumn("dbo.Chefs", "ImageUrl", c => c.String());
            AlterColumn("dbo.Products", "Ingredients", c => c.String());
            AlterColumn("dbo.Products", "ImageUrl", c => c.String());
            AlterColumn("dbo.Products", "ProductName", c => c.String());
            AlterColumn("dbo.Categories", "CategoryName", c => c.String());
            AlterColumn("dbo.Abouts", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Abouts", "VideoUrl", c => c.String());
            AlterColumn("dbo.Abouts", "Description", c => c.String());
            AlterColumn("dbo.Abouts", "Item3", c => c.String());
            AlterColumn("dbo.Abouts", "Item2", c => c.String());
            AlterColumn("dbo.Abouts", "Item1", c => c.String());
            AlterColumn("dbo.Abouts", "TopDescription", c => c.String());
            AlterColumn("dbo.Abouts", "ImageUrl2", c => c.String());
            AlterColumn("dbo.Abouts", "ImageUrl1", c => c.String());
        }
    }
}
