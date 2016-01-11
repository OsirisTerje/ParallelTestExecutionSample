using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ParallelTestExecution4
{
    public class Test4
    {
        [Test]
        public void Test5Secs4()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(true);
        }
    }
}
