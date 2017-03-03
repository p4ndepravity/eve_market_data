namespace Eve_Market_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMarginToTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Types", "TypeMargin", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Types", "TypeMargin");
        }
    }
}
