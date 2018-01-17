namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedPeopleTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "City", c => c.String());
            AddColumn("dbo.People", "State", c => c.String());
            AddColumn("dbo.People", "ZipCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "ZipCode");
            DropColumn("dbo.People", "State");
            DropColumn("dbo.People", "City");
        }
    }
}
