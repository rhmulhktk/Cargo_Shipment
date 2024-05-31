namespace Cargo_Shipment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShipAppoinments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Consignee = c.String(nullable: false),
                        Origin = c.String(nullable: false),
                        Destination = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Desc = c.String(nullable: false),
                        BDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ShipAppoinments");
        }
    }
}
