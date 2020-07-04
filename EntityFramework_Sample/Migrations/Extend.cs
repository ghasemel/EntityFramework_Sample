using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;

namespace EntityFramework_Sample.Migrations
{
    static class Extend
    {
        public static void CreateView(this DbMigration migration, string viewName, string viewQueryString)
        {
            ((IDbMigration)migration)
                .AddOperation(new CreateViewOperation(viewName,
                    viewQueryString));
        }

        public static void DropView(this DbMigration migration, string viewName)
        {
            ((IDbMigration)migration)
                .AddOperation(new DropViewOperation(viewName));
        }
    }
}
