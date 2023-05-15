namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit_ques : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ques", "TeacherName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ques", "TeacherName");
        }
    }
}
