namespace Tourcy1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContinentToToursClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Continents",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Tours", "ContinentId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Tours", "ContinentId");
            AddForeignKey("dbo.Tours", "ContinentId", "dbo.Continents", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tours", "ContinentId", "dbo.Continents");
            DropIndex("dbo.Tours", new[] { "ContinentId" });
            DropColumn("dbo.Tours", "ContinentId");
            DropTable("dbo.Continents");
        }
    }
}
