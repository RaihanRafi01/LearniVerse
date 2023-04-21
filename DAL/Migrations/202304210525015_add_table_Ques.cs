namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_table_Ques : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ques",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Question = c.String(),
                        Option1 = c.String(),
                        Option2 = c.String(),
                        Option3 = c.String(),
                        Option4 = c.String(),
                        CorrectAns = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ques");
        }
    }
}
