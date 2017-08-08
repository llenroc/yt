namespace YT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class awdawd : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AbpRoles", newName: "yt_roles");
            RenameTable(name: "dbo.AbpUsers", newName: "yt_users");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.yt_users", newName: "AbpUsers");
            RenameTable(name: "dbo.yt_roles", newName: "AbpRoles");
        }
    }
}
