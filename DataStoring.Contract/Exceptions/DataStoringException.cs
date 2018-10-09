using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MM.PersonManagerApp.Data.DataStoring.Contract.Exceptions
{
    [Serializable]
    public class DataStoringException : Exception
    {
        public DataStoringException()
        {
        }

        public DataStoringException(string message) : base(message)
        {
        }

        public DataStoringException(string message, Exception inner) : base(message, inner)
        {
        }

        protected DataStoringException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    public class DataFormatException : DataStoringException
    {

        public DataFormatException()
        {
        }

        public DataFormatException(string message) : base(message)
        {
        }

        public DataFormatException(string message, Exception inner) : base(message, inner)
        {
        }

        protected DataFormatException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    public class DataSourceInitializeException : DataStoringException
    {
        public DataSourceInitializeException()
        {
        }

        public DataSourceInitializeException(string message) : base(message)
        {
        }

        public DataSourceInitializeException(string message, Exception inner) : base(message, inner)
        {
        }

        protected DataSourceInitializeException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }

}
