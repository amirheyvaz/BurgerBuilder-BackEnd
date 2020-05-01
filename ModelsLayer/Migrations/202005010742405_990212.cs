namespace ModelsLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _990212 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "BB.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("BB.Orders", "UserID", c => c.Int(nullable: false));
            CreateIndex("BB.Orders", "UserID");
            AddForeignKey("BB.Orders", "UserID", "BB.Users", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("BB.Orders", "UserID", "BB.Users");
            DropIndex("BB.Orders", new[] { "UserID" });
            DropColumn("BB.Orders", "UserID");
            DropTable("BB.Users");
        }
    }
}
