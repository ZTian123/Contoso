using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model
{
    [Table("Instructors")]
    public class Instructor: People
    {
        public DateTime HireDate { get; set; }

        //used for junction table InstrctorCourses
        public ICollection<Course> Courses { get; set; }
    }
}
