namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit_course : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "TeacherName", c => c.String());
            AddColumn("dbo.Courses", "StudentName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "StudentName");
            DropColumn("dbo.Courses", "TeacherName");
        }
    }
}
