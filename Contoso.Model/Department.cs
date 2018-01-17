using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Common;

namespace Contoso.Model
{
    public class Department: AuditableEntity
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime? StartDate { get; set; }
        public int? RowVersion { get; set; }

        //FK: department => instroctor; many to one; department是FK table
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        
        //FK: department => courses; one to many; course是FK table
        public virtual ICollection<Course> Courses { get; set; }//no influence to migrations

    }
}
