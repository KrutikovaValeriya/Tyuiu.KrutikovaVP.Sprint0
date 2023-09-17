using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KrutikovaVP.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KrutikovaVP.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Валерия";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Валерия", res);
        }
    }
}
