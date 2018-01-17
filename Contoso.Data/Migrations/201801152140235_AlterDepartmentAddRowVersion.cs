namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterDepartmentAddRowVersion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "RowVersion", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "RowVersion");
        }
    }
}
