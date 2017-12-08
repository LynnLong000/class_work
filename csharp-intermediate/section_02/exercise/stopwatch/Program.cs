using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

            for(var i = 0; i < 2; i++)
            {
                stopwatch.Start(DateTime.Now);

                for(var j = 0; j <= 1000; j++)
                {
                    Thread.Sleep(1);
                }

               stopwatch.Stop(DateTime.Now);

                Console.WriteLine(stopwatch.GetInterval().ToString());
                Console.ReadLine();
            }
        }
    }
}
