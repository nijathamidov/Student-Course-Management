namespace Student.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyFirstCourseMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CourseModels", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.StudentModels", "Email", c => c.String(nullable: false));
            AddColumn("dbo.StudentModels", "EnrolmentDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CourseModels", "CourseName", c => c.String(nullable: false));
            AlterColumn("dbo.StudentModels", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.StudentModels", "LastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentModels", "LastName", c => c.String());
            AlterColumn("dbo.StudentModels", "FirstName", c => c.String());
            AlterColumn("dbo.CourseModels", "CourseName", c => c.String());
            DropColumn("dbo.StudentModels", "EnrolmentDate");
            DropColumn("dbo.StudentModels", "Email");
            DropColumn("dbo.CourseModels", "Price");
        }
    }
}
