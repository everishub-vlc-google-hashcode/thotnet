using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Thotnet.HashCode2019.SlideMaker;

namespace Thotnet.HashCode2019.IO
{
    public static class OutputWriter
    {
        public static void WriteOutput(List<Slide> slideShow, string path = @"C:\thotnet\output.txt")
        {
            var fileText = string.Empty;

            fileText += slideShow.Count;
            fileText += "\n";
        
            foreach (var slide in slideShow)
            {
                fileText += slide.PhotoId1;
                fileText += (slide.PhotoId2 != -1) ? $" {slide.PhotoId2.ToString()}\n" :  "\n";
            }

            File.WriteAllText(path, fileText);
        }
    }
}
