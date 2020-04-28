using System;
using System.Collections.Generic;
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
            ContactData cname = new ContactData("asdafs");

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.AddNewContactName(cname);

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.Add(cname);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}

