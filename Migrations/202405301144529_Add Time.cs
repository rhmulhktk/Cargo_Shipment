namespace Cargo_Shipment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShipAppoinments", "BTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ShipAppoinments", "BTime");
        }
    }
}
