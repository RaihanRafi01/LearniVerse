namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up11 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Results", "Qid", "dbo.Ques");
            DropForeignKey("dbo.Ques", "Sid", "dbo.Students");
            DropIndex("dbo.Ques", new[] { "Sid" });
            DropIndex("dbo.Results", new[] { "Qid" });
            AddColumn("dbo.Students", "Rid", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "Rid");
            AddForeignKey("dbo.Students", "Rid", "dbo.Results", "Id", cascadeDelete: true);
            DropColumn("dbo.Ques", "Sid");
            DropColumn("dbo.Results", "Qid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Results", "Qid", c => c.Int(nullable: false));
            AddColumn("dbo.Ques", "Sid", c => c.Int(nullable: false));
            DropForeignKey("dbo.Students", "Rid", "dbo.Results");
            DropIndex("dbo.Students", new[] { "Rid" });
            DropColumn("dbo.Students", "Rid");
            CreateIndex("dbo.Results", "Qid");
            CreateIndex("dbo.Ques", "Sid");
            AddForeignKey("dbo.Ques", "Sid", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Results", "Qid", "dbo.Ques", "Id", cascadeDelete: true);
        }
    }
}
