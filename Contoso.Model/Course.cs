using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;//Annotations
using Contoso.Model.Common;

namespace Contoso.Model
{
    public class Course: AuditableEntity
    {
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        public int Credits { get; set; }

        //FK courses=>departments; many to one
        public int DepartmentId { get; set; }
        public Department Department { get; set; }//convention for add FK

        //used for junction table InstrctorCourses
        public ICollection<Instructor> Instructors { get; set; }
    }
}
