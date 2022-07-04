using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var program = new Homework1.Program();
            new Thread(program.Consume).Start();
            Thread.Sleep(100);
            new Thread(program.Produce).Start();
            Thread.Sleep(100);
            Assert.IsFalse(program.cake.Error);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var program = new Homework1.Program();
            new Thread(program.Produce).Start();
            Thread.Sleep(100);
            new Thread(program.Consume).Start();
            Thread.Sleep(100);
            Assert.IsFalse(program.cake.Error);
        }
    }
}