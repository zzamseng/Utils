using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Test
{
    public class PrintStopWatch
    {
        public static void Start<T>(Func<T> func)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            func();
            stopwatch.Stop();
            Console.WriteLine($"Funtion elapsed time: {stopwatch.ElapsedMilliseconds.ToString()}");
        }
    }
}
