namespace BackendAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFrame1822 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Frames", "DurationFrame", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Frames", "DurationFrame", c => c.DateTime(nullable: false));
        }
    }
}
