namespace Cargo_Shipment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConsignmentBooks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConsignmentBooks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CNIC = c.String(nullable: false),
                        Consignee = c.String(nullable: false),
                        Shiper = c.String(nullable: false),
                        ShiperCNIC = c.String(nullable: false),
                        ShiperEmail = c.String(),
                        ShiperPhone = c.String(nullable: false),
                        Origin = c.String(nullable: false),
                        Destination = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        Email = c.String(),
                        ConsigneePhone = c.String(nullable: false),
                        Desc = c.String(),
                        CurrentStatus = c.String(nullable: false),
                        BDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ConsignmentBooks");
        }
    }
}
