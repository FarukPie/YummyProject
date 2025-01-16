namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "ImageUrl2", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abouts", "ImageUrl2", c => c.Int(nullable: false));
        }
    }
}
