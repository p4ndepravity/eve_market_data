namespace Eve_Market_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTypeIdInGame : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Types", "TypeIdInGame", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Types", "TypeIdInGame");
        }
    }
}
