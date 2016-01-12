using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public void Test5Secs3()
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
