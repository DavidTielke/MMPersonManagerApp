using System;
using System.Runtime.Serialization;

namespace MM.PersonManagerApp.Logic.PersonManagement.Contract.Exceptions
{
    [Serializable]
    public class CantCalculateAgeStatisticException : PersonManagementException
    {

        public CantCalculateAgeStatisticException()
        {
        }

        public CantCalculateAgeStatisticException(string message) : base(message)
        {
        }

        public CantCalculateAgeStatisticException(string message, Exception inner) : base(message, inner)
        {
        }

        protected CantCalculateAgeStatisticException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}