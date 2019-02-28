using System;
using System.Diagnostics;
using Thotnet.HashCode2019.IO;
using Thotnet.HashCode2019.SlideMaker;

namespace Thotnet.HashCode2019.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();

            //var photos = new ThotFileReader().ParseInput(@"C:\thotnet\b_lovely_landscapes.txt");
            var photos = new ThotFileReader().ParseInput(@"C:\thotnet\b_lovely_landscapes.txt");

            var slideshow = SlideshowMaker.GetSlides(photos);

            //DO SHIT HERE FFS!
            watch.Stop();
            Console.WriteLine($"Execution time => {watch.ElapsedMilliseconds} miliseconds");
            Console.ReadLine();
        }
    }
}
