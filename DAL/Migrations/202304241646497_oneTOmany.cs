namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class oneTOmany : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "CId", c => c.Int(nullable: false));
            AddColumn("dbo.Teachers", "SId", c => c.Int(nullable: false));
            AddColumn("dbo.Teachers", "GId", c => c.Int(nullable: false));
            CreateIndex("dbo.Teachers", "CId");
            CreateIndex("dbo.Teachers", "SId");
            CreateIndex("dbo.Teachers", "GId");
            AddForeignKey("dbo.Teachers", "CId", "dbo.Courses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Teachers", "GId", "dbo.Guardians", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Teachers", "SId", "dbo.Students", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "SId", "dbo.Students");
            DropForeignKey("dbo.Teachers", "GId", "dbo.Guardians");
            DropForeignKey("dbo.Teachers", "CId", "dbo.Courses");
            DropIndex("dbo.Teachers", new[] { "GId" });
            DropIndex("dbo.Teachers", new[] { "SId" });
            DropIndex("dbo.Teachers", new[] { "CId" });
            DropColumn("dbo.Teachers", "GId");
            DropColumn("dbo.Teachers", "SId");
            DropColumn("dbo.Teachers", "CId");
        }
    }
}
