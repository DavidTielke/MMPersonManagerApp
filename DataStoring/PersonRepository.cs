using System.Collections.Generic;
using System.IO;
using System.Linq;
using DataStoring.Contract;
using MM.PersonManagerApp.CrossCutting.DataClasses;

namespace MM.PersonManagerApp.Data.DataStoring
{
    public class PersonRepository : IPersonRepository
    {
        public IQueryable<Person> Query => File.ReadAllLines("data.csv")
            .Select(l => l.Split(','))
            .Select(p => new Person
            {
                Id = int.Parse(p[0]),
                Name = p[1],
                Age = int.Parse(p[2])
            })
            .AsQueryable();
    }
}
