namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class u02 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Guardians", "Sid", "dbo.Students");
            DropIndex("dbo.Guardians", new[] { "Sid" });
            CreateIndex("dbo.StGus", "Sid");
            CreateIndex("dbo.StGus", "Gid");
            AddForeignKey("dbo.StGus", "Gid", "dbo.Guardians", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StGus", "Sid", "dbo.Students", "Id", cascadeDelete: true);
            DropColumn("dbo.Guardians", "Sid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Guardians", "Sid", c => c.Int(nullable: false));
            DropForeignKey("dbo.StGus", "Sid", "dbo.Students");
            DropForeignKey("dbo.StGus", "Gid", "dbo.Guardians");
            DropIndex("dbo.StGus", new[] { "Gid" });
            DropIndex("dbo.StGus", new[] { "Sid" });
            CreateIndex("dbo.Guardians", "Sid");
            AddForeignKey("dbo.Guardians", "Sid", "dbo.Students", "Id", cascadeDelete: true);
        }
    }
}
