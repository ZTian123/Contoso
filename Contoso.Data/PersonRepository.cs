using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class PersonRepository : Repository<People>, IPersonRepository
    {
        //base 8个method
        public PersonRepository(ContosoDbContext context) : base(context)
        {
        }
        //1个method
        public People GetPersonByLastName(string lastName)
        {
            var person = _context.People.Where(p => p.LastName == lastName).FirstOrDefault();//_context是dbcontext
            return person;
        }
    }

    //8+1=9个method，add specific method inside this interface
    public interface IPersonRepository : IRepository<People> {
        People GetPersonByLastName(String name);
    }
}
