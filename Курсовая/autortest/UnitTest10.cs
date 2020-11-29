using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace autortest
{
    [TestClass]
    public class UnitTest10
    {
        [TestMethod]
        public void SearchPacient()
        {
            PojectGANkurs.windowfolder.patienswindow page = new PojectGANkurs.windowfolder.patienswindow();
            Assert.IsTrue(page.search("Леон", "Романенко"));
            Assert.IsTrue(page.search("Гавриил ", "Романенко"));
            Assert.IsTrue(page.search("Артемий", "Лукашенко"));
            Assert.IsFalse(page.search("Гавриил", "Гавриил"));
            Assert.IsFalse(page.search("Гавриил", "Гавриил"));
            Assert.IsFalse(page.search("Гавриил", "Леон"));
        }
    }
}
