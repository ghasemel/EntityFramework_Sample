using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_Sample.Database
{
    public class Standard
    {
        public Standard()
        {

        }

        public int StandardId { get; set; }
        public string StandardName { get; set; }

        [InverseProperty("CurrentStandard")]
        public virtual IList<Student> CurrentStudents { get; set; }

        //[InverseProperty("PreviousStandard")]
        //public virtual IList<Student> PreviousStudents { get; set; }
    }
}
