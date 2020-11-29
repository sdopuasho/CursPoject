using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace autortest
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void Docinfoupdate()
        {
            PojectGANkurs.windowfolder.doctorwindow page = new PojectGANkurs.windowfolder.doctorwindow();
            Assert.IsTrue(page.tthisupdate("update212", "update", "update", "update", "update", "update", 7));
            Assert.IsTrue(page.tthisupdate("update11", "update1", "update1", "update1", "update1", "update1", 8));
            Assert.IsTrue(page.tthisupdate("update21", "update21", "update2", "update2", "update2", "update2", 10));
            Assert.IsFalse(page.tthisupdate("update", "update", "update", "update", "update", "update", 500));
            Assert.IsFalse(page.tthisupdate("update1", "update1", "update1", "update1", "update1", "update1", 21212));
            Assert.IsFalse(page.tthisupdate("update2", "update2", "update2", "update2", "update2", "update2", 5012120));
        }
    }
}
