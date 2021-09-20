namespace TaskForEttuso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personals",
                c => new
                    {
                        PersonalId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        BirthDay = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.PersonalId);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        PhoneId = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(),
                        PersonalId = c.Int(),
                    })
                .PrimaryKey(t => t.PhoneId)
                .ForeignKey("dbo.Personals", t => t.PersonalId)
                .Index(t => t.PersonalId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "PersonalId", "dbo.Personals");
            DropIndex("dbo.Phones", new[] { "PersonalId" });
            DropTable("dbo.Phones");
            DropTable("dbo.Personals");
        }
    }
}
