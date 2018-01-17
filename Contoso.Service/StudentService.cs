using Contoso.Data;
using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRository;
        //constroctor
        public StudentService(IStudentRepository studentRository)
        {
            _studentRository = studentRository;
        }
        //IStudentService
        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRository.GetAll();
        }

        public Student GetStudentById(int id)
        {
            return _studentRository.GetById(id);
        }

        public Student GetStudentByLastName(string lastName)
        {
            return _studentRository.GetStudentByLastName(lastName);
        }
    }
    public interface IStudentService {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentByLastName(string lastName);
        Student GetStudentById(int id);

        //void CreateStudent(Student student);
        //void UpdateStudent(Student student);
    }
}
