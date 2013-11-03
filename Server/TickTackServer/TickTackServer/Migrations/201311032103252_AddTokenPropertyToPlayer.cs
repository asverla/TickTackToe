namespace TickTackServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTokenPropertyToPlayer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "token", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "token");
        }
    }
}
