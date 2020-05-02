using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;

namespace addressbook_testing2
{
    [TestFixture]

    class ContactModificationTests : AuthTestBases
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newName = new ContactData("wwww", "xxxx");
            newName.Middle_name = "xxxx";
            newName.Nick_name = "vvvv";

            app.Contacts.ContactExists();
            app.Contacts.Modify(newName);
        }

    }
}
