namespace Tourcy1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAvailableCapacity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tours", "AvailableCapacity", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tours", "AvailableCapacity");
        }
    }
}
