namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme33 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Abouts", "ImageUrl2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "ImageUrl2", c => c.String());
        }
    }
}
