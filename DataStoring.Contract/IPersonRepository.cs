using System.Linq;
using MM.PersonManagerApp.CrossCutting.DataClasses;

namespace DataStoring.Contract
{
    public interface IPersonRepository
    {
        IQueryable<Person> Query { get; }
    }
}