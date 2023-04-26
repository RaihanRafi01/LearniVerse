namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finalRe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StGus", "Tid", c => c.Int(nullable: false));
            CreateIndex("dbo.StGus", "Tid");
            AddForeignKey("dbo.StGus", "Tid", "dbo.Teachers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StGus", "Tid", "dbo.Teachers");
            DropIndex("dbo.StGus", new[] { "Tid" });
            DropColumn("dbo.StGus", "Tid");
        }
    }
}
