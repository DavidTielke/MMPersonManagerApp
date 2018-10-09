using System;
using System.Linq;
using System.Runtime.InteropServices;
using DataStoring.Contract;
using MM.PersonManagerApp.CrossCutting.DataClasses;
using MM.PersonManagerApp.Logic.PersonManagement.Contract;
using MM.PersonManagerApp.Logic.PersonManagement.Contract.DataClasses;
using MM.PersonManagerApp.Logic.PersonManagement.Contract.Exceptions;

namespace MM.PersonManagerApp.Logic.PersonManagement
{
    public class PersonManager : IPersonManager
    {
        private readonly IPersonRepository _repository;

        public PersonManager(IPersonRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<Person> GetAllAdults() => _repository.Query.Where(p => p.Age >= 18);
        public IQueryable<Person> GetAllChildren() => _repository.Query.Where(p => p.Age < 18);
        public AgeStatistic GetAgeStatistic()
        {
            try
            {
                return new AgeStatistic
                {
                    AmountAdults = GetAllAdults().Count(),
                    AmountChildren = GetAllChildren().Count()
                };
            }
            catch (Exception e)
            {
                throw new CantCalculateAgeStatisticException("Keine Ahnung warum....", e);
            }
        }
    }
}
