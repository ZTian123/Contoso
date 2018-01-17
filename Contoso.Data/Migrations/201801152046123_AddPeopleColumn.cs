namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPeopleColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "AddressLine1", c => c.String());
            AddColumn("dbo.People", "AddressLine2", c => c.String());
            AddColumn("dbo.People", "UnitOrApartmentNumber", c => c.String());
            AddColumn("dbo.People", "Password", c => c.String());
            AddColumn("dbo.People", "Salt", c => c.String());
            AddColumn("dbo.People", "IsLocked", c => c.Boolean(nullable: false));
            AddColumn("dbo.People", "LastLockedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.People", "FailedAttempts", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "FailedAttempts");
            DropColumn("dbo.People", "LastLockedDateTime");
            DropColumn("dbo.People", "IsLocked");
            DropColumn("dbo.People", "Salt");
            DropColumn("dbo.People", "Password");
            DropColumn("dbo.People", "UnitOrApartmentNumber");
            DropColumn("dbo.People", "AddressLine2");
            DropColumn("dbo.People", "AddressLine1");
        }
    }
}
