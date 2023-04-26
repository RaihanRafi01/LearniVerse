namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class quizresult : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuizResults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Qid = c.Int(nullable: false),
                        Rid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ques", t => t.Qid, cascadeDelete: true)
                .ForeignKey("dbo.Results", t => t.Rid, cascadeDelete: true)
                .Index(t => t.Qid)
                .Index(t => t.Rid);
            
            AlterColumn("dbo.Guardians", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuizResults", "Rid", "dbo.Results");
            DropForeignKey("dbo.QuizResults", "Qid", "dbo.Ques");
            DropIndex("dbo.QuizResults", new[] { "Rid" });
            DropIndex("dbo.QuizResults", new[] { "Qid" });
            AlterColumn("dbo.Guardians", "Gender", c => c.Int(nullable: false));
            DropTable("dbo.QuizResults");
        }
    }
}
