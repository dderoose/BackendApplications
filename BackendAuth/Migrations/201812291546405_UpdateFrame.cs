namespace BackendAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFrame : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Frames", "PointsWinner", c => c.Int(nullable: false));
            AddColumn("dbo.Frames", "PointsOpponent", c => c.Int(nullable: false));
            DropColumn("dbo.Frames", "Points");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Frames", "Points", c => c.Int(nullable: false));
            DropColumn("dbo.Frames", "PointsOpponent");
            DropColumn("dbo.Frames", "PointsWinner");
        }
    }
}
