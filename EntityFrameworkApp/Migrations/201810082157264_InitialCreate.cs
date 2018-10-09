namespace EntityFrameworkApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        StreetNumber = c.Int(nullable: false),
                        City = c.String(nullable: false, maxLength: 128),
                        CodeP = c.String(nullable: false, maxLength: 128),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StreetNumber, t.City, t.CodeP })
                .ForeignKey("dbo.persons", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.persons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 20),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "PersonId", "dbo.persons");
            DropIndex("dbo.Addresses", new[] { "PersonId" });
            DropTable("dbo.persons");
            DropTable("dbo.Addresses");
        }
    }
}
