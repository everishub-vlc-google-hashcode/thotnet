using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Thotnet.HashCode2019.Runner
{
    public class ParserText
    {
        const string FilePath = @"C:\thotnet\example.txt";

        int TotalPhotos = 0;


        //public IEnumerable<Photo> ParseInput(string path = FilePath)
        public void ParseInput(string path = FilePath)
        {
            var textArray = File.ReadAllLines(path);

            var duh = 1;

        }
    }
}
