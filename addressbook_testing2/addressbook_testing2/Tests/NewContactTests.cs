using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_testing2
{
    [TestFixture]
    class NewContactTests : TestBase
    {
        [Test]
        public void NewContactTest()
        {
            OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            GoToAddNew();
            ContactData cname = new ContactData("First name");
            cname.Middle_name = "Middle name";
            cname.Last_name = "Last name";
            cname.Nick_name = "Nick name";
            ContactNameInformation(cname);
            AddContact();
            LogOut();
        }
    }
}
