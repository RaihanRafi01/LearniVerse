namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removingallRelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teachers", "CId", "dbo.Courses");
            DropForeignKey("dbo.Teachers", "GId", "dbo.Guardians");
            DropForeignKey("dbo.Teachers", "QId", "dbo.Ques");
            DropForeignKey("dbo.Teachers", "SId", "dbo.Students");
            DropIndex("dbo.Teachers", new[] { "QId" });
            DropIndex("dbo.Teachers", new[] { "CId" });
            DropIndex("dbo.Teachers", new[] { "SId" });
            DropIndex("dbo.Teachers", new[] { "GId" });
            DropColumn("dbo.Teachers", "QId");
            DropColumn("dbo.Teachers", "CId");
            DropColumn("dbo.Teachers", "SId");
            DropColumn("dbo.Teachers", "GId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "GId", c => c.Int(nullable: false));
            AddColumn("dbo.Teachers", "SId", c => c.Int(nullable: false));
            AddColumn("dbo.Teachers", "CId", c => c.Int(nullable: false));
            AddColumn("dbo.Teachers", "QId", c => c.Int(nullable: false));
            CreateIndex("dbo.Teachers", "GId");
            CreateIndex("dbo.Teachers", "SId");
            CreateIndex("dbo.Teachers", "CId");
            CreateIndex("dbo.Teachers", "QId");
            AddForeignKey("dbo.Teachers", "SId", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Teachers", "QId", "dbo.Ques", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Teachers", "GId", "dbo.Guardians", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Teachers", "CId", "dbo.Courses", "Id", cascadeDelete: true);
        }
    }
}
