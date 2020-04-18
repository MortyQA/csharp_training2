using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_testing2
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBases
    {
        [Test]
        public void GroupRemovalTest()
        {
            app.Groups.Remove(1);
        }
    }
}
