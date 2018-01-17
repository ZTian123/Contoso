namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterPeopleColumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "LastLockedDateTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "LastLockedDateTime", c => c.DateTime(nullable: false));
        }
    }
}
