namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tea_stu_Ques : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ques", "Tid", c => c.Int(nullable: false));
            AddColumn("dbo.Ques", "Sid", c => c.Int(nullable: false));
            CreateIndex("dbo.Ques", "Tid");
            CreateIndex("dbo.Ques", "Sid");
            AddForeignKey("dbo.Ques", "Sid", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Ques", "Tid", "dbo.Teachers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ques", "Tid", "dbo.Teachers");
            DropForeignKey("dbo.Ques", "Sid", "dbo.Students");
            DropIndex("dbo.Ques", new[] { "Sid" });
            DropIndex("dbo.Ques", new[] { "Tid" });
            DropColumn("dbo.Ques", "Sid");
            DropColumn("dbo.Ques", "Tid");
        }
    }
}
