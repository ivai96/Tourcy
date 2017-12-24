namespace Tourcy1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContinentTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tours", "Capacity", c => c.Byte(nullable: false));
            AlterColumn("dbo.Tours", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tours", "Name", c => c.String());
            DropColumn("dbo.Tours", "Capacity");
        }
    }
}
