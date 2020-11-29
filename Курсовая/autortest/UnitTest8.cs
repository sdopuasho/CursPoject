using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace autortest
{
    [TestClass]
    public class UnitTest8
    {
        [TestMethod]
        public void RaspisanieGroup()
        {
            PojectGANkurs.windowfolder.Raspisanie page = new PojectGANkurs.windowfolder.Raspisanie();
            Assert.IsTrue(page.takeall("Понедельник", "Марочко", "Юлий"));
            Assert.IsTrue(page.takeall("Вторник", "Назаров", "Камиль"));
            Assert.IsTrue(page.takeall("Четверг", "Марочко", "Юлий"));
            Assert.IsFalse(page.takeall("Среда", "test", "test"));
            Assert.IsFalse(page.takeall("Суббота", "test", "test"));
            Assert.IsFalse(page.takeall("Воскресенье", "test", "test"));
            Assert.IsTrue(page.takeday("Понедельник"));
            Assert.IsTrue(page.takeday("Вторник"));
            Assert.IsTrue(page.takeday("Четверг"));
            Assert.IsFalse(page.takeday("Среда"));
            Assert.IsFalse(page.takeday("Воскресенье"));
            Assert.IsFalse(page.takeday("Суббота"));
            Assert.IsTrue(page.takedoc("Марочко", "Юлий"));
            Assert.IsTrue(page.takedoc("Острожска", "Гелла"));
            Assert.IsTrue(page.takedoc("Назаров", "Камиль"));
            Assert.IsFalse(page.takedoc("tester", "tester"));
            Assert.IsFalse(page.takedoc("tester1", "tester1"));
            Assert.IsFalse(page.takedoc("tester1", "tester1"));
        }
    }
}
