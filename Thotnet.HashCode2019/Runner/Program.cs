using System;
using System.Diagnostics;

namespace Thotnet.HashCode2019.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();

            //DO SHIT HERE FFS!
            watch.Stop();
            Console.WriteLine($"Execution time => {watch.ElapsedMilliseconds} miliseconds");
            Console.ReadLine();
        }
    }
}
