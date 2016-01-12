using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test5Secs()
        {
            var x = 5.6d;
            var s = Stopwatch.StartNew();
            s.Start();
            while (s.ElapsedMilliseconds < 5000)
            {
                for (int i = 0; i < 2000000; i++)
                {
                    x = x * i / (Math.Sqrt(i));
                }
            }
            Assert.IsTrue(true);
        }
    }
}
