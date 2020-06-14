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
            ContactData newName = new ContactData("wwww", "xxxx",0, null, null, null, null, null, null);
            newName.Middle_name = "xcv";
            newName.Nick_name = "xcv";

            List<ContactData> oldContacts = app.Contacts.GetContactList();
            ContactData oldData = oldContacts[0];

            app.Contacts.ContactExists();
            app.Contacts.Modify(newName);

            Assert.AreEqual(oldContacts.Count, app.Contacts.GetContactCount());

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts[0].First_name = newName.First_name;
            oldContacts[0].Last_name = newName.Last_name;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);

            foreach (ContactData contacts in newContacts)
            {
                if (contacts.Id == oldData.Id)
                {
                    Assert.AreEqual(newName.First_name, contacts.First_name);
                    Assert.AreEqual(newName.Last_name, contacts.Last_name);
                }
            }
        }
    }
}
