namespace BackendAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeaverageshottimetodateofmatch : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matches", "DateOfMatch", c => c.DateTime(nullable: false));
            DropColumn("dbo.Matches", "AverageShotTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Matches", "AverageShotTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Matches", "DateOfMatch");
        }
    }
}
