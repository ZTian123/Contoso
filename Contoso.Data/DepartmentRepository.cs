using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ContosoDbContext context) : base(context)
        {
        }

        public Department GetDepartmentByName(string name)
        {
            var dept = _context.Departments.FirstOrDefault(d => d.Name == name);
            //dept.Courses = _context.Courses.Where(c => c.DepartmentId == dept.Id).ToList();
            return dept;
        }

        
    }
    public interface IDepartmentRepository : IRepository<Department>
    {
        //IEnumerable<Department> GetDepartments();//already implemented in Repository<T>
        Department GetDepartmentByName(string name);
        //Department GetDepartmentById(int id);//already implemented in Repository<T>
        //void AddDepartment(Department department);//already implemented in Repository<T>


    }
}
