using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace autortest
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void Checkpointresult()
        {
            PojectGANkurs.windowfolder.windowifin page = new PojectGANkurs.windowfolder.windowifin();
            Assert.IsTrue(page.rsad(5, 3));
            Assert.IsFalse(page.rsad(0, 3));
            Assert.IsFalse(page.rsad(5, 0));
        }
    }
}
