namespace MedApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUsersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(false, 32),
                        Name = c.String(),
                        Password = c.String(),
                        Salt = c.String(),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Username, unique: true, name: "UN_Username");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.User", "UN_Username");
            DropTable("dbo.User");
        }
    }
}
