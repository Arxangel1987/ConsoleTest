using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello world";
        [TestMethod]
        public void TestMethod1()
        {
            using (var context = new StringWriter())
            {
                Console.SetOut(context);
                ConsoleTest.Program.Main();
                var result=context.ToString().Trim();
                Assert.AreNotEqual(Expected, result);
            }
        }
    }
}