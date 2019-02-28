using System;
using System.Collections.Generic;
using System.Text;

namespace Thotnet.HashCode2019.SlideMaker
{
    public class Scoring
    {
        public Scoring(Slide sl1, Slide sl2)
        {

        }

        public int Min(Slide sl1, Slide sl2)
        {
            var min = 0;
            var commonTags = 0;
            var sl1Count = sl1.Tags.Count;
            var sl2Count = sl2.Tags.Count;

            // TODOS FALTA COMPROBAR LOS CASOS DE IGUALES

            foreach (var sl1Tag in sl1.Tags)
            {
                if (sl2.Tags.Contains(sl1Tag))
                {
                    commonTags++;
                }

                if (commonTags > sl1Count || commonTags > sl2Count)
                {
                    if (sl1Count <= sl2Count)
                    {
                        return sl1Count;
                    }
                    else
                    {
                        return sl2Count;
                    }
                }
            }            

            if ((sl1Count < sl2Count) && (sl1Count < commonTags))
            {
                min = sl1Count;
            }
            else if ((sl2Count < sl1Count) && (sl2Count < commonTags))
            {
                min = sl2Count;
            }
            else if ((commonTags < sl1Count) && (commonTags < sl2Count))
            {
                min = commonTags;
            }
            return min;
        }
    }
}
