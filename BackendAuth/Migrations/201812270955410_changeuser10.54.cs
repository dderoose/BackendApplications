namespace BackendAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeuser1054 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "Level");
            DropColumn("dbo.AspNetUsers", "LastTimeVisitNotifications");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "LastTimeVisitNotifications", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Level", c => c.Byte(nullable: false));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
