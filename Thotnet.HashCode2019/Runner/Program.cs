using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
            var photos = new ThotFileReader().ParseInput(@"C:\thotnet\c_memorable_moments.txt");

            var slideshow = SlideshowMaker.GetSlides(photos);
            var sortedSlides = slideshow.OrderBy(s => s.Tags.Count).ToList();

            var matchedSlides = SlideMatcher.MatchSlides(sortedSlides);

            var duh = new List<Slide>(slideshow.Count);

            watch.Stop();

            Console.WriteLine($"Execution time => {watch.ElapsedMilliseconds} miliseconds");

            var score = 0;

            for (int i = 0; i < slideshow.Count-1; i++)
            {
                score = score + Scoring.Min(slideshow[i], slideshow[i + 1]);
            }
            Console.WriteLine($"Score without doing nothing => {score}");

            for (int i = 0; i < sortedSlides.Count - 1; i++)
            {
                score = score + Scoring.Min(sortedSlides[i], sortedSlides[i + 1]);
            }
            Console.WriteLine($"Score ordered=> {score}");


            for (int i = 0; i < matchedSlides.Count - 1; i++)
            {
                score = score + Scoring.Min(matchedSlides[i], matchedSlides[i + 1]);
            }
            Console.WriteLine($"Score matched => {score}");

            Console.ReadLine();
        }
    }
}
