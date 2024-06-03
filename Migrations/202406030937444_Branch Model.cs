namespace Cargo_Shipment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BranchModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BranchName = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Contact = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        MapUrl = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Branches");
        }
    }
}
