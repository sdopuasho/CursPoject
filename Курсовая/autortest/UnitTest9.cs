using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace autortest
{
    [TestClass]
    public class UnitTest9
    {
        [TestMethod]
        public void Recordregistr()
        {
            PojectGANkurs.windowfolder.regiin page = new PojectGANkurs.windowfolder.regiin();
            Assert.IsTrue(page.regup("Артемий", "Лукашенко", "12:00:00", "г Томск", "2019-02-20", 1, 2, 1));
            Assert.IsFalse(page.regup("ntestuser", "wtestuser", "14:00:00", "no", "2019-12-18", 3, 7, 1));
            Assert.IsFalse(page.regup("vtestuser", "etestuser", "14:00:00", "test", "2019-12-18", 3, 7, 1));
            Assert.IsFalse(page.regup("atestuser", "ttestuser", "14:00:00", "test", "2019-12-18", 3, 7, 1));
        }
    }
}
