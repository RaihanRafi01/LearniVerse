namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Te_st_R : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Tid", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "Tid");
            AddForeignKey("dbo.Students", "Tid", "dbo.Teachers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Tid", "dbo.Teachers");
            DropIndex("dbo.Students", new[] { "Tid" });
            DropColumn("dbo.Students", "Tid");
        }
    }
}
