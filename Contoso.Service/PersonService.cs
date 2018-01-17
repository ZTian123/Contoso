using Contoso.Data;
using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service
{
    public class PersonService : IPersonService
    {
        //dependency injection
        private readonly IPersonRepository _personRepository;
        //ctor
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        //IpersonService interface
        public void AddPerson(People people)
        {
            _personRepository.Add(people);
            _personRepository.SaveChanges();//???????
        }

        public IEnumerable<People> GetAllPeople()
        {
            return _personRepository.GetAll();
        }

        public People GetPersonById(int id)
        {
            return _personRepository.GetById(id);
        }
    }

    public interface IPersonService
    {
        IEnumerable<People> GetAllPeople();
        People GetPersonById(int id);
        void AddPerson(People people);

    }
}
