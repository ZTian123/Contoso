using Contoso.Data;
using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service
{
    public class CourseService : ICourseService
    {
        //DI
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        //interface
        public void AddCourse(Course course)
        {
            _courseRepository.Add(course);
            _courseRepository.SaveChanges();//???
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _courseRepository.GetAll();
        }

        public Course GetCourseById(int id)
        {
            return _courseRepository.GetById(id);
        }

        public void UpdateCourse(Course course)
        {
            _courseRepository.Update(course);
        }
    }
    public interface ICourseService {
        IEnumerable<Course> GetAllCourses();
        Course GetCourseById(int id);
        void AddCourse(Course course);
        void UpdateCourse(Course course);
    }
}
