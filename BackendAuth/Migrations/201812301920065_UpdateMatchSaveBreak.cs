namespace BackendAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMatchSaveBreak : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matches", "OpslaanBreak", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Matches", "OpslaanBreak");
        }
    }
}
