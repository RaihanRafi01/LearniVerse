namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resQues : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Results", "Qid", c => c.Int(nullable: false));
            CreateIndex("dbo.Results", "Qid");
            AddForeignKey("dbo.Results", "Qid", "dbo.Ques", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "Qid", "dbo.Ques");
            DropIndex("dbo.Results", new[] { "Qid" });
            DropColumn("dbo.Results", "Qid");
        }
    }
}
