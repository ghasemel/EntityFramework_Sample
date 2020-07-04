using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Database.SchoolDB())
            {
                Database.Standard stand = new Database.Standard() { StandardName = "standard 1" };
                stand = db.Standards.Add(stand);
                //ctx.SaveChanges();

                Database.Student st = new Database.Student() { StudentName = "Raouf", DateOfBirth = DateTime.Now }; //, PreviousStandardRefId = stand.StandardId };
                db.Students.Add(st);
                db.SaveChanges();

                //db.V_Student.ToList();


                // List<Database.Student> lst = db.Students.ToList();


                DataLayer.StudentDAL StudentDAL = DataLayer.StudentDAL.CreateSudentDAL();

                Console.WriteLine(StudentDAL.GaxMaxId());

            }
        }
    }
}
