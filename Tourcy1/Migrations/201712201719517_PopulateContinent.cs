namespace Tourcy1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateContinent : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Continents (Id, Name) VALUES (1,'America')");
            Sql("INSERT INTO Continents (Id, Name) VALUES (2,'Asia')");
            Sql("INSERT INTO Continents (Id, Name) VALUES (3,'Europe')");
        }
        
        public override void Down()
        {
        }
    }
}
