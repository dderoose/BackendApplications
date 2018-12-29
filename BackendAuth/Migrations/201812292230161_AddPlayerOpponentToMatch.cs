namespace BackendAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPlayerOpponentToMatch : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matches", "Player", c => c.String());
            AddColumn("dbo.Matches", "Opponent", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Matches", "Opponent");
            DropColumn("dbo.Matches", "Player");
        }
    }
}
