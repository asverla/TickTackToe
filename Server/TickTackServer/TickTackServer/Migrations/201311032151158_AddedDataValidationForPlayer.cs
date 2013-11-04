namespace TickTackServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDataValidationForPlayer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "GemeData", c => c.String());
            AlterColumn("dbo.Players", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Players", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Players", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Players", "Password", c => c.String());
            AlterColumn("dbo.Players", "Username", c => c.String());
            AlterColumn("dbo.Players", "Email", c => c.String());
            DropColumn("dbo.Games", "GemeData");
        }
    }
}
