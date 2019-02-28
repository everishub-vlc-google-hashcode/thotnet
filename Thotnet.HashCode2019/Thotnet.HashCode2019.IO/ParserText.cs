using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Thotnet.HashCode2019.SlideMaker;

namespace Thotnet.HashCode2019.Runner
{
    public class ThotFileReader
    {
        const string FilePath = @"C:\thotnet\example.txt";

        int TotalPhotos = 0;


        public IEnumerable<Photo> ParseInput(string path = FilePath)
        {
            var textArray = File.ReadAllLines(path);

            var duh = 1;

            return Enumerable.Empty<Photo>();
        }
    }
}
