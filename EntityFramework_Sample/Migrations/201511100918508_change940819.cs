namespace EntityFramework_Sample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change940819 : DbMigration
    {
        public override void Up()
        {
           /* CreateTable(
                "dbo.V_Student",
                c => new
                    {
                        StandardId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        StandardName = c.String(),
                        StudentName = c.String(),
                    })
                .PrimaryKey(t => new { t.StandardId, t.StudentId });*/
            this.CreateView(@"dbo.V_STUDENT", 
@"SELECT        dbo.Standards.StandardId, dbo.Standards.StandardName, dbo.Students.StudentID, dbo.Students.StudentName
FROM            dbo.Standards INNER JOIN
                         dbo.Students ON dbo.Standards.StandardId = dbo.Students.CurrentStandardId
");
        }
        
        public override void Down()
        {
            //DropTable("dbo.V_Student");
            //this.Sql(@"DROP VIEW dbo.V_STUDENT");
            this.DropView("V_STUDENT");
        }
    }
}
