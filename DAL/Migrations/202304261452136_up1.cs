namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Tid", "dbo.Teachers");
            DropForeignKey("dbo.Guardians", "Tid", "dbo.Teachers");
            DropIndex("dbo.Guardians", new[] { "Tid" });
            DropIndex("dbo.Students", new[] { "Tid" });
            CreateTable(
                "dbo.StGus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sid = c.Int(nullable: false),
                        Gid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Guardians", "Sid", c => c.Int(nullable: false));
            CreateIndex("dbo.Guardians", "Sid");
            AddForeignKey("dbo.Guardians", "Sid", "dbo.Students", "Id", cascadeDelete: true);
            DropColumn("dbo.Guardians", "Tid");
            DropColumn("dbo.Students", "Tid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Tid", c => c.Int(nullable: false));
            AddColumn("dbo.Guardians", "Tid", c => c.Int(nullable: false));
            DropForeignKey("dbo.Guardians", "Sid", "dbo.Students");
            DropIndex("dbo.Guardians", new[] { "Sid" });
            DropColumn("dbo.Guardians", "Sid");
            DropTable("dbo.StGus");
            CreateIndex("dbo.Students", "Tid");
            CreateIndex("dbo.Guardians", "Tid");
            AddForeignKey("dbo.Guardians", "Tid", "dbo.Teachers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Students", "Tid", "dbo.Teachers", "Id", cascadeDelete: true);
        }
    }
}
