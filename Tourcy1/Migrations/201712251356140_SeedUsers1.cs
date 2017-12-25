namespace Tourcy1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'45767d20-2f7c-4dc6-8f9b-91ac87480c5f', N'admin@tourcy.com', 0, N'ABGnoMXaPL7Xj/2Y3C2BkasNMH6osqjsNzcS/PlUaYQ5mecuLpuKqGbNV1NYnAeddg==', N'64dede80-9b25-4f08-8816-f1289ce907d1', NULL, 0, 0, NULL, 1, 0, N'admin@tourcy.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'be9a5177-26f4-4147-841f-7b12286acc38', N'guest@tourcy.com', 0, N'AJMzDtyd5s587LjrdVRriudj2QVQPv8dgZHC3mgLyDps+o1SB5+sV7oaI2zkL2FBVg==', N'59486e55-f3b0-4748-b007-44e987a51b71', NULL, 0, 0, NULL, 1, 0, N'guest@tourcy.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b811028e-e517-49c0-9074-e69bb160e332', N'CanManageTours')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'45767d20-2f7c-4dc6-8f9b-91ac87480c5f', N'b811028e-e517-49c0-9074-e69bb160e332')

");
        }
        
        public override void Down()
        {
        }
    }
}
