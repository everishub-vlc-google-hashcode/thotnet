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

            var duh = false;
        
            foreach (var slide in slideShow)
            {
                if (!duh)
                {
                    fileText += slide.PhotoId1;
                    fileText += (slide.PhotoId2 != -1) ? $" {slide.PhotoId2.ToString()}\n" : "\n";

                    duh = true;
                }
                else
                {
                    duh = false;
                }
            }

            File.WriteAllText(path, fileText);
        }
    }
}
