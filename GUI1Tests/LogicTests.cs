using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUI1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void MinMaxTest1()
        {
            int a = 9;
            int b = 6;
            int c = 3;
            var Out = Logic.MinMax(a, b, c);
            Assert.AreEqual("Произведение наименьших чисел равно = 18", Out);
        }
        [TestMethod()]
        public void MinMaxTest2()
        {
            int a = 4;
            int b = 12;
            int c = 8;
            var Out = Logic.MinMax(a, b, c);
            Assert.AreEqual("Произведение наименьших чисел равно = 32", Out);
        }
        [TestMethod()]
        public void MinMaxTest3()
        {
            int a = 5;
            int b = 12;
            int c = 23;
            var Out = Logic.MinMax(a, b, c);
            Assert.AreEqual("Произведение наименьших чисел равно = 60", Out);
        }
    }
}