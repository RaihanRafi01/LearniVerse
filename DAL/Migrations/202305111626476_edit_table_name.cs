namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit_table_name : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.StGus", newName: "StudentGuardianTeachers");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.StudentGuardianTeachers", newName: "StGus");
        }
    }
}
