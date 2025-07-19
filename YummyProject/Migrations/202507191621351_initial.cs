namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutID = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        Item1 = c.String(),
                        Item2 = c.String(),
                        Item3 = c.String(),
                        Description = c.String(),
                        VideoUrl = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.AboutID);
            
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        BookingDate = c.DateTime(nullable: false),
                        PersonCount = c.Int(nullable: false),
                        MessageContent = c.String(),
                        IsApproved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BookingID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ImageUrl = c.String(),
                        Ingredients = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Chefs",
                c => new
                    {
                        ChefID = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        Name = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ChefID);
            
            CreateTable(
                "dbo.ChefSocials",
                c => new
                    {
                        ChefSocialID = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        Icon = c.String(),
                        SocialMediaName = c.String(),
                        ChefID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ChefSocialID)
                .ForeignKey("dbo.Chefs", t => t.ChefID, cascadeDelete: true)
                .Index(t => t.ChefID);
            
            CreateTable(
                "dbo.ContactInfoes",
                c => new
                    {
                        ContactInfoID = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        MapUrl = c.String(),
                        OpenHours = c.String(),
                    })
                .PrimaryKey(t => t.ContactInfoID);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.EventID);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureID = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        VideoUrl = c.String(),
                    })
                .PrimaryKey(t => t.FeatureID);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Subject = c.String(),
                        MessageContent = c.String(),
                        IsRead = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MessageID);
            
            CreateTable(
                "dbo.PhotoGalleries",
                c => new
                    {
                        PhotoGalleryID = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.PhotoGalleryID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Icon = c.String(),
                    })
                .PrimaryKey(t => t.ServiceID);
            
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        TestimonialID = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        NameSurname = c.String(),
                        Title = c.String(),
                        Comment = c.String(),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TestimonialID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChefSocials", "ChefID", "dbo.Chefs");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropIndex("dbo.ChefSocials", new[] { "ChefID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropTable("dbo.Testimonials");
            DropTable("dbo.Services");
            DropTable("dbo.PhotoGalleries");
            DropTable("dbo.Messages");
            DropTable("dbo.Features");
            DropTable("dbo.Events");
            DropTable("dbo.ContactInfoes");
            DropTable("dbo.ChefSocials");
            DropTable("dbo.Chefs");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
            DropTable("dbo.Bookings");
            DropTable("dbo.Abouts");
        }
    }
}
