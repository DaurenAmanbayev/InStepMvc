namespace InStep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        Address = c.String(),
                        AdditionalPhone = c.String(),
                        Skype = c.String(),
                        Twitter = c.String(),
                        OwnerSite = c.String(),
                        Interest = c.String(),
                        FavoriteMusic = c.String(),
                        FavoriteFilms = c.String(),
                        FavoriteBooks = c.String(),
                        FavoriteGames = c.String(),
                        About = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserProfiles");
        }
    }
}
