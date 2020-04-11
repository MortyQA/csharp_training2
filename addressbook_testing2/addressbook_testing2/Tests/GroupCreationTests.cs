using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_testing2
{
    [TestFixture]
    class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitNewGroupCreation();
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "fff";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupPage();
            LogOut();
        }     
    }
}
