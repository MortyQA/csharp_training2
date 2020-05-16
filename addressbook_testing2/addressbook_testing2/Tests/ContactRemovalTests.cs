using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace addressbook_testing2
{
    [TestFixture]
    public class RemoveContactTests : AuthTestBases
    {
        [Test]
        public void RemoveContactTest()
        {
            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.ContactExists();
            app.Contacts.Remove(0);

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.RemoveAt(0);
            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}
