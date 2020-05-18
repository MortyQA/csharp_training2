using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;


namespace addressbook_testing2
{
    [TestFixture]

    public class SearchTests : AuthTestBases
    {
        [Test]
        public void TestSearch()
        {
            System.Console.Out.Write(app.Contacts.GetNumberOfSearchResult());
        }
    }
}
