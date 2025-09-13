using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YushkovaE.Sprint0.Task2.V0.Lib;

namespace Tyuiu.YushkovaE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]

        public void CheckGetMessageValid()
        {
            var name = "Катя";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Катя", res);
        }
    }
}
