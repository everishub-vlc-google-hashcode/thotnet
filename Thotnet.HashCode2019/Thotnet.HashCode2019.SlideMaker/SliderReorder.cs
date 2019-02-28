using System;
using System.Collections.Generic;
using System.Text;

namespace Thotnet.HashCode2019.SlideMaker
{
    static class SliderReorder
    {
        public static Slide[] Reorder(Slide[] slides)
        {
            var bestScore = -1;

            var length = slides.Length;

            for (int i = 0; i < length; i++)
            {
                for (int x = 1; x < length; x++)
                {
                    var score = Scoring.Min(slides[i], slides[x]);

                    if (score > bestScore)
                    {
                        bestScore = score;

                        var aux = slides[x];

                        slides[x] = slides[i + 1];
                        slides[i + 1] = aux;
                    }
                }
            }

            return slides;
        }
    }
}
