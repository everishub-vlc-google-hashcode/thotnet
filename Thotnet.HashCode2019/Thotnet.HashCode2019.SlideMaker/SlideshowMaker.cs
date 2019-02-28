using System;
using System.Collections.Generic;
using System.Text;

namespace Thotnet.HashCode2019.SlideMaker
{
    class SlideshowMaker
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
    }
}
