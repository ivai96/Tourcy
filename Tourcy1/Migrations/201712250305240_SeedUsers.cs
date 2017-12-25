namespace Tourcy1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'65b1553e-5c4a-471f-b2d7-c38aa2b70ee0', N'guest@tourcy.com', 0, N'AOuonMUXhJcwXlYZaktVsrr99yW80BQRZWTnJ+IHZX2riYpy6zP6noehszBWVtlJKQ==', N'43f47c12-53fc-4ac5-9d00-8f9b9931a1ee', NULL, 0, 0, NULL, 1, 0, N'guest@tourcy.com')
INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'd2ba1309-9f3f-420a-8c81-a6e62286469d', N'admin@tourcy.com', 0, N'ALedaxbHyLPAK7v+1wscZ5MU4LOX6kgJgV7Auam4g2YBA2DwCTEPi6XKCudy90ztrQ==', N'a80db02f-5056-4fb2-9c5e-8621a5b55595', NULL, 0, 0, NULL, 1, 0, N'admin@tourcy.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ebd19105-65f1-4714-850d-8aa3423490b3', N'CanManageTours')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd2ba1309-9f3f-420a-8c81-a6e62286469d', N'ebd19105-65f1-4714-850d-8aa3423490b3')


");
        }
        
        public override void Down()
        {
        }
    }
}
