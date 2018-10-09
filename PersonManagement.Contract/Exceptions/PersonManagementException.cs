using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MM.PersonManagerApp.Logic.PersonManagement.Contract.Exceptions
{
    [Serializable]
    public class PersonManagementException : Exception
    {
        public PersonManagementException()
        {
        }

        public PersonManagementException(string message) : base(message)
        {
        }

        public PersonManagementException(string message, Exception inner) : base(message, inner)
        {
        }

        protected PersonManagementException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
