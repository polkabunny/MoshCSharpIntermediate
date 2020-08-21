using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Thread.Sleep(500);
            stopwatch.Stop();

            var duration = stopwatch.GetDuration();

            Console.WriteLine($"Duration: {duration}");
        }
    }
}
