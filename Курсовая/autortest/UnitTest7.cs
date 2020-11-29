using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace autortest
{
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        public void Patienceupdateinfo()
        {
            PojectGANkurs.windowfolder.update page = new PojectGANkurs.windowfolder.update();
            Assert.IsTrue(page.thisupdate("change1", "change1", "change1", "change1", "change1", "change1", 20));
            Assert.IsTrue(page.thisupdate("change2", "change2", "change2", "change2", "change2", "change2", 21));
            Assert.IsTrue(page.thisupdate("change3", "change3", "change3", "change3", "change3", "change3", 22));
            Assert.IsFalse(page.thisupdate("change33", "change33", "change33", "change33", "change33", "change33", 150));
            Assert.IsFalse(page.thisupdate("change33", "change33", "change33", "change33", "change33", "change33", 151));
            Assert.IsFalse(page.thisupdate("change33", "change33", "change33", "change33", "change33", "change33", 152));
        }
    }
}
