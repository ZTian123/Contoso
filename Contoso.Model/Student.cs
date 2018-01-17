using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.Model
{
    [Table("Students")]//make students as a table instead of a attribute of people
    public class Student : People
    {
        public DateTime? EnrollmentDate { get; set; }

        //FK: student.Id => Enrollents, one to many, not change to migration
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
