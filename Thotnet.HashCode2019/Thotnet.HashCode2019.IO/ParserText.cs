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

            var photoList = new List<Photo>();

            int.TryParse(textArray[0], out var totalPhotos);

            for (int i = 1; i < textArray.Length; i++)
            {
                var line = textArray[i].Split(' ');

                var photo = new Photo()
                {
                    IsVertical = (line[0] == "H") ? false : true,
                    TagCount = Convert.ToInt32(line[1]),
                    Tags = new List<string>()
                };

                for (int x = 2; x < line.Length; x++)
                {
                    photo.Tags.Add(line[x]);
                }

                photoList.Add(photo);
            }


            return photoList;
        }

    }
}
