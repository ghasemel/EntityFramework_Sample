using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Sample.DataLayer
{
    public class StudentDAL
    {
        Database.SchoolDB mDB;
        static StudentDAL sStudentDalObj;


        public static StudentDAL CreateSudentDAL()
        {
            if (sStudentDalObj == null)
                sStudentDalObj = new StudentDAL();

            return sStudentDalObj;
        }

        private StudentDAL()
        {
            mDB = new Database.SchoolDB();
        }

        public int GaxMaxId()
        {
            return mDB.Students.Max(s => s.StudentID);
        }
    }
}
