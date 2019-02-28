using System;
using System.Collections.Generic;
using System.Text;

namespace Thotnet.HashCode2019.SlideMaker
{
    public class SlideshowMaker
    {
        public static List<Slide> GetSlides(Photo[] photos)
        {
            var slides = new List<Slide>();
            var bufferedVerticalPhoto = 0;
            var count = 0;

            foreach (var photo in photos)
            {
                if (!photo.IsVertical)
                {
                    slides.Add(new Slide(photo));
                }
                else if (bufferedVerticalPhoto == -1)
                {
                    bufferedVerticalPhoto = count;
                }
                else
                {
                    slides.Add(new Slide(photos[bufferedVerticalPhoto], photo));
                    bufferedVerticalPhoto = -1;
                }
                count++;
            }
            return slides;
        }

        public static List<Slide> GetSlidesSortedByNumberOfTags(List<Slide> slides)
        {
            slides.Sort((x, y) => y.Tags.Count.CompareTo(x.Tags.Count));
            return slides;
        }
    }
}
