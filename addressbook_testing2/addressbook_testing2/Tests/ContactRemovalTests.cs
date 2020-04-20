using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_testing2
{
    [TestFixture]
    public class RemoveContactTests : AuthTestBases
    {
        [Test]
        public void RemoveContactTest()
        {
            app.Contacts.ContactExists();
            app.Contacts.Remove(1);
        }
    }
}
