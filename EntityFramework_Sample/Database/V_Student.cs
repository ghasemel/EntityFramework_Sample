using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_Sample.Database
{
    public class V_Student
    {
        public V_Student() { }


        [Key]
        [Column(Order=1)]
        public int StandardId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int StudentId { get; set; }


        public string StandardName { get; set; }
        public string StudentName { get; set; }

    }
}
