using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonstantinovaJN.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Юлия";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Юлия", res);
        }
    }
}
