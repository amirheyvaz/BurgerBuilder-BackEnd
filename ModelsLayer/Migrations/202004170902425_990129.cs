namespace ModelsLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _990129 : DbMigration
    {
        public override void Up()
        {
            AddColumn("BB.Orders", "FirstName", c => c.String());
            AddColumn("BB.Orders", "LastName", c => c.String());
            AddColumn("BB.Orders", "EmailAddress", c => c.String());
            AddColumn("BB.Orders", "PhoneNumber", c => c.String());
            AddColumn("BB.Orders", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("BB.Orders", "Address");
            DropColumn("BB.Orders", "PhoneNumber");
            DropColumn("BB.Orders", "EmailAddress");
            DropColumn("BB.Orders", "LastName");
            DropColumn("BB.Orders", "FirstName");
        }
    }
}
