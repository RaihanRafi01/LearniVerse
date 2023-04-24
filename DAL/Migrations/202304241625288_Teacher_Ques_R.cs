namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teacher_Ques_R : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "QId", c => c.Int(nullable: false));
            CreateIndex("dbo.Teachers", "QId");
            AddForeignKey("dbo.Teachers", "QId", "dbo.Ques", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "QId", "dbo.Ques");
            DropIndex("dbo.Teachers", new[] { "QId" });
            DropColumn("dbo.Teachers", "QId");
        }
    }
}
