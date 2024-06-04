namespace Cargo_Shipment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdinPanel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UpdatNews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        News = c.String(nullable: false),
                        NewsDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UpdatNews");
        }
    }
}
