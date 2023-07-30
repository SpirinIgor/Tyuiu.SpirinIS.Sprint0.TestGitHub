using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SpirinIS.Sprint0.Task6.V0.Lib;

namespace Tyuiu.SpirinIS.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
      
        [TestMethod]
        public void CheckAdditionArrayValid() {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void CheckSubstractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray(numbers);
            Assert.AreEqual(-15, res);
        }

        [TestMethod]
        public void CheckMultArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}















//    [TestMethod]
//    public void CheckedAdditionValid()
//    {
//        Assert.AreEqual(10, DataService.Addition(5, 5));
//    }

//    [TestMethod]
//    public void CheckedSubtractionValid()
//    {
//        Assert.AreEqual(5, DataService.Subtraction(10, 5));
//    }

//    [TestMethod]
//    public void CheckedMultiplicationValid()
//    {
//        Assert.AreEqual(50, DataService.Multiplication(10, 5));
//    }

//    [TestMethod]
//    public void CheckedDivisionValid()
//    {
//        Assert.AreEqual(3, DataService.Division(9, 3));
//    }









