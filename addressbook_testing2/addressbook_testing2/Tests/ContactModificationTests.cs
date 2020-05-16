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
            newName.Middle_name = "xcv";
            newName.Nick_name = "xcv";

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.ContactExists();
            app.Contacts.Modify(newName);

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts[0].First_name = newName.First_name;
            oldContacts[0].Last_name = newName.Last_name;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);

        }

    }
}
