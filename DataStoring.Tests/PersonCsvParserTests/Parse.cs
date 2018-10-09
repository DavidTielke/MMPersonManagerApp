using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MM.PersonManagerApp.Data.DataStoring;

namespace DataStoring.Tests.PersonCsvParserTests
{

    public partial class PersonCsvParserTest
    {
        [TestMethod]
        public void Parse_EmptyLine_EmptyCollectionReturned()
        {
            var lines = new String[] { "1,David,27"};

            var persons = new PersonCsvParser().Parse(lines);

            persons
                .Should()
                .BeEmpty("the data input contained no data lines");
        }
    }
}
