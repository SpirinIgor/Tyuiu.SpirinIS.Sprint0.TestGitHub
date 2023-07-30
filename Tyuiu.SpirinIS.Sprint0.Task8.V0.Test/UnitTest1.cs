using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SpirinIS.Sprint0.Task8.V0.Lib;

namespace Tyuiu.SpirinIS.Sprint0.Task8.V0.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Igor";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Hello, Igor", res);
        }
    }
}
