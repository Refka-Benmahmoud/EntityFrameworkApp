namespace EntityFrameworkApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_column_sex_person : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.persons", "Sex", c => c.String(maxLength: 1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.persons", "Sex");
        }
    }
}
