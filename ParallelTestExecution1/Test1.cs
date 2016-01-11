using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ParallelTestExecution
{
    public class Test1
    {
        [Test]
        public void Test3Secs()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(true);
        }
    }
}
