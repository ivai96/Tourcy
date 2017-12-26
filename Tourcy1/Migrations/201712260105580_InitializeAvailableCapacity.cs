namespace Tourcy1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeAvailableCapacity : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Tours SET AvailableCapacity = Capacity");
        }
        
        public override void Down()
        {
        }
    }
}
