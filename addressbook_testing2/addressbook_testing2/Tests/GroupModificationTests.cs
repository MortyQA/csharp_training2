using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_testing2
{
    [TestFixture]

    public  class GroupModificationTests : AuthTestBases
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("zzz");
            newData.Header = "qqq";
            newData.Footer = "www";

            app.Groups.GroupExists();
            app.Groups.Modify(1, newData);
        }

    }
}
