namespace ModelsLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "BB.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SaladAmount = c.Int(nullable: false),
                        CheeseAmount = c.Int(nullable: false),
                        MeatAmount = c.Int(nullable: false),
                        BaconAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("BB.Orders");
        }
    }
}
