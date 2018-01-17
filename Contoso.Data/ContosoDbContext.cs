using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Contoso.Model;

namespace Contoso.Data
{
    public class ContosoDbContext: DbContext
    {
        public ContosoDbContext(): base("name = ContosoDbContext")
        {
        }
        //创建table
        public DbSet<People> People { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Role> Roles { get; set; }
        //public DbSet<PersonRole> PersonRoles { get; set; }//can't build migration, has no key defined
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
    }
}
