using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.Model
{
    public class OfficeAssignment: AuditableEntity
    {
        //FK: OfficeAssignment is table
        [System.ComponentModel.DataAnnotations.Key]
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        public string Location { get; set; }
    }
}
