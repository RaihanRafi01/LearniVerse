namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Student_QuizResult : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Rid", "dbo.Results");
            DropIndex("dbo.Students", new[] { "Rid" });
            AddColumn("dbo.QuizResults", "Sid", c => c.Int(nullable: false));
            CreateIndex("dbo.QuizResults", "Sid");
            AddForeignKey("dbo.QuizResults", "Sid", "dbo.Students", "Id", cascadeDelete: true);
            DropColumn("dbo.Students", "Rid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Rid", c => c.Int(nullable: false));
            DropForeignKey("dbo.QuizResults", "Sid", "dbo.Students");
            DropIndex("dbo.QuizResults", new[] { "Sid" });
            DropColumn("dbo.QuizResults", "Sid");
            CreateIndex("dbo.Students", "Rid");
            AddForeignKey("dbo.Students", "Rid", "dbo.Results", "Id", cascadeDelete: true);
        }
    }
}
