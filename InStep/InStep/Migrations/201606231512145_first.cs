namespace InStep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        SecondName = c.String(),
                        Sex = c.Boolean(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        PhoneNumber = c.String(),
                        Email = c.String(nullable: false),
                        Password = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserDatas");
        }
    }
}
