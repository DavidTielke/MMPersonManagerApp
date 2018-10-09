using System.Collections.Generic;
using System.IO;
using System.Linq;
using DataStoring.Contract;
using MM.PersonManagerApp.CrossCutting.DataClasses;

namespace MM.PersonManagerApp.Data.DataStoring
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IFileStorer _fileStorer;
        private readonly IPersonParser _personParser;

        public PersonRepository(IFileStorer fileStorer, IPersonParser personParser)
        {
            _fileStorer = fileStorer;
            _personParser = personParser;
        }

        public IQueryable<Person> Query
        {
            get
            {
                var lines = _fileStorer.ReadLines("data.csv");
                var persons = _personParser.Parse(lines);
                return persons.AsQueryable();
            }
        }
    }

    public interface IPersonParser
    {
        IEnumerable<Person> Parse(IEnumerable<string> lines);
    }

    public class PersonCsvParser : IPersonParser
    {
        public IEnumerable<Person> Parse(IEnumerable<string> lines) => lines
            .Select(l => l.Split(','))
            .Select(p => new Person
            {
                Id = int.Parse(p[0]),
                Name = p[1],
                Age = int.Parse(p[2])
            });
    }


    public interface IFileStorer
    {
        string[] ReadLines(string path);
    }

    public class FileStorer : IFileStorer
    {
        public string[] ReadLines(string path) => File.ReadAllLines(path);
    }
}
