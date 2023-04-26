namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teacherStudent_Course : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Tid", c => c.Int(nullable: false));
            AddColumn("dbo.Courses", "Sid", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "Tid");
            CreateIndex("dbo.Courses", "Sid");
            AddForeignKey("dbo.Courses", "Sid", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Courses", "Tid", "dbo.Teachers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Tid", "dbo.Teachers");
            DropForeignKey("dbo.Courses", "Sid", "dbo.Students");
            DropIndex("dbo.Courses", new[] { "Sid" });
            DropIndex("dbo.Courses", new[] { "Tid" });
            DropColumn("dbo.Courses", "Sid");
            DropColumn("dbo.Courses", "Tid");
        }
    }
}
