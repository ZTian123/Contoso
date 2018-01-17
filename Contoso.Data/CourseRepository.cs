using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Contoso.Data
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        //no DI
        public CourseRepository(ContosoDbContext context) : base(context)
        {
        }

        //interface
        public Course GetCourseByName(string name)
        {
            var course = _context.Courses.Where(c => c.Title == name).FirstOrDefault();
            return course;
        }
    }
    public interface ICourseRepository : IRepository<Course> {
        Course GetCourseByName(String name);
    }
}
