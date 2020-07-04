using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
 

namespace EntityFramework_Sample.Database
{
    public class SchoolDB : DbContext 
    {
        public SchoolDB()
            : base("name=EntityFramework_Sample.Properties.Settings.SchoolContext") //"MySchoolDB") //"name=EntityFramework_Sample.Database.SchoolContext")
        {
            System.Data.Entity.Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolDB, EntityFramework_Sample.Migrations.Configuration>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<V_Student> V_Student { get; set; }
        public DbSet<member> member { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }       
    }
}
