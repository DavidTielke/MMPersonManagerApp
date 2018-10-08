using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStoring.Contract;
using MM.PersonManagerApp.CrossCutting.DataClasses;

namespace DataStoring.InMemory
{
    public class PersonMemRepository : IPersonRepository
    {
        public IQueryable<Person> Query => new List<Person>
        {
            new Person {Id = 1, Name = "Hugo", Age = 22},
            new Person {Id = 2, Name = "Foo", Age = 3,}
        }.AsQueryable();
    }
}
