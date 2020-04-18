using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_testing2
{
    [TestFixture]
    class ContactCreationTests : AuthTestBases
    {
        [Test]
        public void NewContactTest()
        {
            ContactData cname = new ContactData("First name");
            cname.Middle_name = "Middle name";
            cname.Last_name = "Last name";
            cname.Nick_name = "Nick name";

            app.Contacts.AddNewContactName(cname);
        }
    }
}
