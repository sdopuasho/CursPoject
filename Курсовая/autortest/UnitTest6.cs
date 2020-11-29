using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace autortest
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void Patienceaddtest()
        {
            PojectGANkurs.windowfolder.RegistrationWindow page = new PojectGANkurs.windowfolder.RegistrationWindow();
            Assert.IsTrue(page.registration("testuser1211", "testuser121", "testuser1", "testuser1", "testuser1", "testuser1"));
            Assert.IsTrue(page.registration("testuser23sa2", "testuser22", "testuser2", "testuser2", "testuser2", "testuser2"));
            Assert.IsTrue(page.registration("testuser32312", "testuser33", "testuser3", "testuser3", "testuser3", "testuser3"));
            Assert.IsFalse(page.registration("change1", "change1", "change1", "change1", "change1", "change1"));
            Assert.IsFalse(page.registration("change2", "change2", "change2", "change2", "change2", "change2"));
            Assert.IsFalse(page.registration("change3", "change3", "change3", "change3", "change3", "change3"));
        }
    }
}
