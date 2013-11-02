namespace TickTackServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GameGUID = c.Guid(nullable: false),
                        Player1_ID = c.Int(),
                        Player2_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Players", t => t.Player1_ID)
                .ForeignKey("dbo.Players", t => t.Player2_ID)
                .Index(t => t.Player1_ID)
                .Index(t => t.Player2_ID);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Ranking = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PlayerPools",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Setting = c.String(),
                        PlayerID_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Players", t => t.PlayerID_ID)
                .Index(t => t.PlayerID_ID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.PlayerPools", new[] { "PlayerID_ID" });
            DropIndex("dbo.Games", new[] { "Player2_ID" });
            DropIndex("dbo.Games", new[] { "Player1_ID" });
            DropForeignKey("dbo.PlayerPools", "PlayerID_ID", "dbo.Players");
            DropForeignKey("dbo.Games", "Player2_ID", "dbo.Players");
            DropForeignKey("dbo.Games", "Player1_ID", "dbo.Players");
            DropTable("dbo.PlayerPools");
            DropTable("dbo.Players");
            DropTable("dbo.Games");
        }
    }
}
