namespace BackendAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMatchAddMatchesWonPlayer2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matches", "NumberMatchesWonPlayer1", c => c.Int(nullable: false));
            AddColumn("dbo.Matches", "NumberMatchesWonPlayer2", c => c.Int(nullable: false));
            DropColumn("dbo.Matches", "NumberMatchesWon");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Matches", "NumberMatchesWon", c => c.Int(nullable: false));
            DropColumn("dbo.Matches", "NumberMatchesWonPlayer2");
            DropColumn("dbo.Matches", "NumberMatchesWonPlayer1");
        }
    }
}
