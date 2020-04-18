using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_testing2
{
    [TestFixture]

    public class LoginTests : TestBase
    {
        [Test]

        public void LoginWithValidCredentials()
        {
            //prepare
            app.Auth.LogOut();

            //action
            AccountData account = new AccountData("admin", "secret");        
            app.Auth.Login(account);

            //verification
            Assert.IsTrue(app.Auth.IsLoggedIn(account));
        }

        [Test]

        public void LoginWithInValidCredentials()
        {
            //prepare
            app.Auth.LogOut();

            //action
            AccountData account = new AccountData("admin", "alkasdaapsijd");
            app.Auth.Login(account);

            //verification
            Assert.IsFalse(app.Auth.IsLoggedIn(account));
        }

    }
}
