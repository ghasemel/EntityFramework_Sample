namespace EntityFramework_Sample.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Model;
    using System.Data.Entity.Migrations.Utilities;
    using System.Data.Entity.SqlServer;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFramework_Sample.Database.SchoolDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("System.Data.SqlClient", new SchoolMigrationSqlGenerator());
        }

        protected override void Seed(EntityFramework_Sample.Database.SchoolDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }


    class SchoolMigrationSqlGenerator : SqlServerMigrationSqlGenerator
    {
        protected override void Generate(System.Data.Entity.Migrations.Model.MigrationOperation migrationOperation)
        {
            if (migrationOperation is CreateViewOperation)
            {
                var operation = migrationOperation as CreateViewOperation;
                if (operation != null)
                {
                    using (IndentedTextWriter writer = Writer())
                    {
                        writer.WriteLine("CREATE VIEW {0} AS {1};",
                            operation.ViewName,
                            operation.ViewString);
                        Statement(writer);
                    }
                }
            }
            else if (migrationOperation is DropViewOperation)
            {
                var operation = migrationOperation as DropViewOperation;
                if (operation != null)
                {
                    using (IndentedTextWriter writer = Writer())
                    {
                        writer.WriteLine("DROP VIEW {0};",
                            operation.ViewName);
                        Statement(writer);
                    }
                }
            }
            //base.Generate(migrationOperation);
        }
    }

    class CreateViewOperation : MigrationOperation
    {
        public CreateViewOperation(string viewName, string viewQueryString)
            : base(null)
        {
            ViewName = viewName;
            ViewString = viewQueryString;
        }

        public string ViewName { get; private set; }
        public string ViewString { get; private set; }
        public override bool IsDestructiveChange
        {
            get { return false; }
        }
    }

    class DropViewOperation : MigrationOperation
    {
        public DropViewOperation(string viewName) 
            : base(null)
        {
            ViewName = viewName;
        }

        public string ViewName { get; private set; }
        public override bool IsDestructiveChange
        {
            get { return false; }
        }
    }
}
