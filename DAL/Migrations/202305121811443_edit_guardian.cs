namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit_guardian : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guardians", "Password", c => c.String());
            AddColumn("dbo.Guardians", "Contact", c => c.String());
            DropColumn("dbo.Guardians", "PhoneNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Guardians", "PhoneNumber", c => c.String());
            DropColumn("dbo.Guardians", "Contact");
            DropColumn("dbo.Guardians", "Password");
        }
    }
}
