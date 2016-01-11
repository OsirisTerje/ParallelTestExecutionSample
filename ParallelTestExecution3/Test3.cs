using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ParallelTestExecution3
{
    public class Test3
    {
        [Test]
        public void Test3Secs3()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(true);
        }
    }
}
