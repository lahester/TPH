namespace TPH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'58c044e5-c6f5-45d1-93da-dc14cd8e623a', N'test@tphtech.com', 0, N'AM1kEDeWwI8MHzClvVtB3p994Vb0ByADsTtbHjk7+CCYG1clGlf2jjoL4R8RWhvfGg==', N'bcba8af3-4b87-4792-9959-54e3905c4068', NULL, 0, 0, NULL, 1, 0, N'test@tphtech.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e901c955-b0a0-4b4d-af19-342e5cf41473', N'admin@tphtech.com', 0, N'AHmeUsx3lD4Wq3W/zocCEUo/vV1iRJzmD48mibhoDjTtXmr3DKsNY8vCsQEUIKYYfg==', N'34ee48c0-499e-4d27-949f-b740d2b9e728', NULL, 0, 0, NULL, 1, 0, N'admin@tphtech.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1b86769b-0dfb-4b48-8d3a-3834a60c63af', N'CanManageProducts')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e901c955-b0a0-4b4d-af19-342e5cf41473', N'1b86769b-0dfb-4b48-8d3a-3834a60c63af')

");
        }
        
        public override void Down()
        {
        }
    }
}
