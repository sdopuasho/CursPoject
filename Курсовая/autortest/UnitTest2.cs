using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace autortest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void changerecodtest()
        {
            PojectGANkurs.windowfolder.Window2 page = new PojectGANkurs.windowfolder.Window2();
            Assert.IsTrue(page.thisupdate("2019-02-20", "11:20:20", 1, 3));
            Assert.IsTrue(page.thisupdate("2019-02-21", "12:30:30", 2, 6));
            Assert.IsTrue(page.thisupdate("2019-02-22", "13:30:10", 3, 9));
            Assert.IsFalse(page.thisupdate("2019-02-23", "10:30:10", 3, 500));
            Assert.IsFalse(page.thisupdate("2019-02-23", "10:30:10", 3, 1239));
            Assert.IsFalse(page.thisupdate("2019-02-23", "10:30:10", 3, 1231239));
        }
    }
}
