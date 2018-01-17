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

        public StudentService(IStudentRepository studentRository)
        {
            _studentRository = studentRository;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRository.GetAll();
        }

        public Student GetStudentByLastName(string lastName)
        {
            return _studentRository.GetStudentByLastName(lastName);
        }
    }
    public interface IStudentService {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentByLastName(string lastName);
    }
}
