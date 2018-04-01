namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0f31357b-2516-4c50-9ed7-0fa85b01f681', N'alexa_deea14@yahoo.com', 0, N'AByLjB/iSh+/cRB3YmAlX214Rgtxje6I+n8jjp8qE397rZl7JxFbwB/ckj5YKEJGoA==', N'3d739fcb-2c2b-4a47-a29d-01c1f951bed9', NULL, 0, 0, NULL, 1, 0, N'alexa_deea14@yahoo.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1fdce93c-a9ff-4ae9-9662-45eb1a17c9ae', N'admin@vidly.com', 0, N'AD4qGHGDatYX4QHBCxgGB4xfjSTE+rKBwi3LBUnwVE9RORYaeRf4TX78dMriQmB9iw==', N'5d8d756d-480a-4b82-a427-529c58d4e028', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e59381c2-8c75-4699-9915-a21b5ab0fcd4', N'CanMAnageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1fdce93c-a9ff-4ae9-9662-45eb1a17c9ae', N'e59381c2-8c75-4699-9915-a21b5ab0fcd4')

");
        }
        
        public override void Down()
        {
        }
    }
}
