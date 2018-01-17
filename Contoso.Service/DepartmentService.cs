using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service
{
    public class DepartmentService : IDepartmentService
    {
        //private readonly IDepartmentRepository _departmentRository;
        public void AddDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            throw new NotImplementedException();
        }

        public Department GetStudentByLastName(string lastName)
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartment(Department department)
        {
            throw new NotImplementedException();
        }
    }
    public interface IDepartmentService
    {
        IEnumerable<Department> GetAllDepartments();
        Department GetStudentByLastName(string lastName);
        void AddDepartment(Department department);
        void UpdateDepartment(Department department);
    }
}
