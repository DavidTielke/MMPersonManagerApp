using System.Linq;
using MM.PersonManagerApp.CrossCutting.DataClasses;
using MM.PersonManagerApp.Logic.PersonManagement.Contract.DataClasses;

namespace MM.PersonManagerApp.Logic.PersonManagement.Contract
{
    public interface IPersonManager
    {
        IQueryable<Person> GetAllAdults();
        IQueryable<Person> GetAllChildren();
        AgeStatistic GetAgeStatistic();
    }
}