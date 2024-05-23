using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba1OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1OOP.Tests
{
    [TestClass()]
    public class RacTests
    {
        [TestMethod()]
        public void NeRov()
        {
            Rac a = new(1, 2);
            Rac b = new(3, 2);
            Rac resPlus = new(4, 2);
            Assert.IsTrue(a - b != resPlus);
        }
        [TestMethod()]
        public void Men()
        {
            Rac a = new(1, 2);
            Rac b = new(3, 2);
            Assert.IsTrue(a < b);
        }
        [TestMethod()]
        public void Bol()
        {
            Rac a = new(1, 2);
            Rac b = new(3, 2);
            Assert.IsFalse(a > b);
        }
        [TestMethod()]
        public void Minus()
        {
            Rac a = new(1, 2);
            Rac b = new(3, 2);
            Rac resMin = new(-2, 2);
            Assert.IsTrue(a - b == resMin);
        }
        [TestMethod()]
        public void Plus()
        {
            Rac a = new(1, 2);
            Rac b = new(3, 2);
            Rac resPlus = new(4, 2);
            Assert.IsTrue(a + b == resPlus);
        }
        [TestMethod()]
        public void MinusUnar()
        {
            Rac a = new(1, 2);
            Rac res = new(-1, 2);
            Assert.IsTrue(-a == res);
        }
    }
}