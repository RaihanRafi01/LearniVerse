namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Te_gu_R : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guardians", "Tid", c => c.Int(nullable: false));
            CreateIndex("dbo.Guardians", "Tid");
            AddForeignKey("dbo.Guardians", "Tid", "dbo.Teachers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Guardians", "Tid", "dbo.Teachers");
            DropIndex("dbo.Guardians", new[] { "Tid" });
            DropColumn("dbo.Guardians", "Tid");
        }
    }
}
