using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace autortest
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void Deletepatience()
        {
            PojectGANkurs.windowfolder.patienswindow page = new PojectGANkurs.windowfolder.patienswindow();
            Assert.IsTrue(page.delete(26));
            Assert.IsTrue(page.delete(27));
            Assert.IsTrue(page.delete(28));
            Assert.IsFalse(page.delete(10550));
            Assert.IsFalse(page.delete(10551));
            Assert.IsFalse(page.delete(10552));
        }
    }
}
