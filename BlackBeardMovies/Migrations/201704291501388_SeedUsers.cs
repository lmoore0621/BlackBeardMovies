namespace BlackBeardMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1411242e-3118-48ad-8765-87c8094240fc', N'guest@blackbeard.com', 0, N'AMReKDCHF+mnGkLekJGYAnK183Qlpjh1DpHzEVnzqvcAd1iQjgTXnxFaQYSczRwBqA==', N'4afa8749-7841-4464-8866-1442443e07a9', NULL, 0, 0, NULL, 1, 0, N'guest@blackbeard.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'24cab9a8-8801-49e6-860a-57081d777166', N'admin@blackbeard.com', 0, N'AB+FtOXhTymJmKt7wkUvp0MMbmZ3S8k10RLPlgzco1SnjTV5cbiSJ6nB/3cZpio48w==', N'87bc376c-27f9-454e-84c7-186ca064628d', NULL, 0, 0, NULL, 1, 0, N'admin@blackbeard.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8bcfae54-df87-400a-b26f-103f15902bd9', N'CanManageMovies')
");
        }
        
        public override void Down()
        {
        }
    }
}
