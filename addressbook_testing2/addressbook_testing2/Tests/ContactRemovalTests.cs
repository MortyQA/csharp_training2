using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_testing2
{
    [TestFixture]
    public class RemoveContactTests : TestBase
    {
        [Test]
        public void RemoveContactTest()
        {
            app.Contacts.Remove(1);
        }
    }
}
