using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;

namespace addressbook_testing2
{
    [TestFixture]

    class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newName = new ContactData("wwww");
            newName.Middle_name = "xxxx";
            newName.Last_name = "zzzz";
            newName.Nick_name = "vvvv";

            app.Contacts.Modify(1, newName);
        }

    }
}
