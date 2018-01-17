using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.Model
{
    //[Table("Enrollment")]
    public class Enrollment: AuditableEntity
    {
        //FK: Enrollments.courseId => Course.Id; many to one; enrollment自己是FK table
        public int CourseId { get; set; }
        public Course Course { get; set; }

        //FK: same
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int? Grade { get; set; }
    }
}
