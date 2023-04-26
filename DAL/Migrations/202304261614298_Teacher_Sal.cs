namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teacher_Sal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Salaries", "Tid", c => c.Int(nullable: false));
            CreateIndex("dbo.Salaries", "Tid");
            AddForeignKey("dbo.Salaries", "Tid", "dbo.Teachers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Salaries", "Tid", "dbo.Teachers");
            DropIndex("dbo.Salaries", new[] { "Tid" });
            DropColumn("dbo.Salaries", "Tid");
        }
    }
}
