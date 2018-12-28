namespace BackendAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMatch010 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Breaks", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Matches", "UserId", "dbo.Users");
            DropIndex("dbo.Breaks", new[] { "User_UserId" });
            DropIndex("dbo.Matches", new[] { "UserId" });
            AlterColumn("dbo.Matches", "UserId", c => c.String());
            DropColumn("dbo.Breaks", "User_UserId");
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        Username = c.String(),
                        Paswoord = c.String(),
                        PaswoordConfirm = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            AddColumn("dbo.Breaks", "User_UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Matches", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Matches", "UserId");
            CreateIndex("dbo.Breaks", "User_UserId");
            AddForeignKey("dbo.Matches", "UserId", "dbo.Users", "UserId");
            AddForeignKey("dbo.Breaks", "User_UserId", "dbo.Users", "UserId");
        }
    }
}
