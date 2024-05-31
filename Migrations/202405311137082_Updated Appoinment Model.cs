namespace Cargo_Shipment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedAppoinmentModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShipAppoinments", "CNIC", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ShipAppoinments", "CNIC");
        }
    }
}
