using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ParallelTestExecution2
{
    public class Test2
    {
        [Test]
        public void Test5Secs2()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(true);
        }
    }
}
