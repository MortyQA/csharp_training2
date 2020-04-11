using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_testing2
{
    [TestFixture]
    class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            SelectGroup(1);
            RemoveGroup();
            ReturnToGroupsPage();
        }
    }
}
