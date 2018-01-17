using Contoso.Data;
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
        //dependency injection
        private readonly IDepartmentRepository _departmentRository;
        public DepartmentService(IDepartmentRepository departmentRository)
        {
            _departmentRository = departmentRository;
        }

        //interface
        public void AddDepartment(Department department)
        {
            _departmentRository.Add(department);
            _departmentRository.SaveChanges();//???
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _departmentRository.GetAll();
        }

        public Department GetDepartmentById(int id)
        {
            return _departmentRository.GetById(id);
        }

        public void UpdateDepartment(Department department)
        {
            _departmentRository.Update(department);
        }
    }
    public interface IDepartmentService
    {
        IEnumerable<Department> GetAllDepartments();
        Department GetDepartmentById(int id);
        void AddDepartment(Department department);
        void UpdateDepartment(Department department);
    }
}
