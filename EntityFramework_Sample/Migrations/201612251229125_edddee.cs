namespace EntityFramework_Sample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edddee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "edddee", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "edddee");
        }
    }
}
