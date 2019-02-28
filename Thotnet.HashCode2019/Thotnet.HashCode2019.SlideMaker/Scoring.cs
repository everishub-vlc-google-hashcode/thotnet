namespace Thotnet.HashCode2019.SlideMaker
{
    public static class Scoring
    {
        public static int Min(Slide sl1, Slide sl2)
        {
            var min = 0;

            var commonTags = 0;

            var sl1Count = sl1.Tags.Count;
            var sl2Count = sl2.Tags.Count;

            foreach (var sl1Tag in sl1.Tags)
            {
                if (sl2.Tags.Contains(sl1Tag))
                {
                    commonTags++;
                }

                if (commonTags > sl1Count || commonTags > sl2Count)
                {
                    break;
                }
            }

            if (commonTags >= sl1Count)
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

            if (commonTags >= sl2Count)
            {
                if (sl2Count <= sl1Count)
                {
                    return sl2Count;
                }
                else
                {
                    return sl1Count;
                }
            }
            return commonTags;
        }
    }
}
