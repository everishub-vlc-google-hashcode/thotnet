using System;
using System.Collections.Generic;
using System.Text;

namespace Thotnet.HashCode2019.SlideMaker
{
    public static class SlideMatcher
    {

        public static List<Slide> MatchSlides(List<Slide> list)
        {
            var maxScore = -1;

            for (int i = 0; i < list.Count; i += 2)
            {
                for (int x = i+1; x < list.Count; x++)
                {
                    var score = Scoring.Min(list[i], list[x]);

                    if(score > maxScore)
                    {
                        maxScore = score;

                        var aux = list[i + 1];
                        list[i + 1] = list[x];
                        list[x] = aux;
                    }
                }
            }

            return list;
        }

    }
}
