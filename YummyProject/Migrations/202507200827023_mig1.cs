namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "ImageUrl1", c => c.String());
            AddColumn("dbo.Abouts", "ImageUrl2", c => c.String());
            AddColumn("dbo.Abouts", "TopDescription", c => c.String());
            DropColumn("dbo.Abouts", "ImageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "ImageUrl", c => c.String());
            DropColumn("dbo.Abouts", "TopDescription");
            DropColumn("dbo.Abouts", "ImageUrl2");
            DropColumn("dbo.Abouts", "ImageUrl1");
        }
    }
}
