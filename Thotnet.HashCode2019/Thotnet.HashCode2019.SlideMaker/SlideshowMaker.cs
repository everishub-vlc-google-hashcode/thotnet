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

        public static List<Slide> SortSlidesNumberOfTags(List<Slide> slides)
        {
            slides.Sort((x, y) => y.Tags.Count.CompareTo(x.Tags.Count));
            return slides;
        }

        public static List<Slide> SortByBestCandidates(List<Slide> slides)
        {
            var slideShow = new List<Slide>();
            var candidate = slides[0];
            var candidateIndex = 0;

            for (int i = 0; i < slides.Count; i++)
            {
                for (int j = 1; j < slides.Count; j++)
                {
                    if (Scoring.Min(slides[i], slides[j]) > Scoring.Min(slides[i], candidate))
                    {
                        candidate = slides[j];
                        candidateIndex = j;
                    }
                }

                if (candidateIndex != 0)
                {
                    slideShow.Add(slides[i]);
                    slideShow.Add(slides[candidateIndex]);
                    slides.RemoveAt(i);
                    
                    if ((candidateIndex != slides.Count)) slides.RemoveAt(candidateIndex);
                }
                // Remains of slides could be reordered in the case of being Vertical to seek more possible combinations and avoid losing all their potential score
            }
            return slideShow;
        }

    }
}
