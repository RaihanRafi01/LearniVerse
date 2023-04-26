namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentPayment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "Sid", c => c.Int(nullable: false));
            CreateIndex("dbo.Payments", "Sid");
            AddForeignKey("dbo.Payments", "Sid", "dbo.Students", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "Sid", "dbo.Students");
            DropIndex("dbo.Payments", new[] { "Sid" });
            DropColumn("dbo.Payments", "Sid");
        }
    }
}
