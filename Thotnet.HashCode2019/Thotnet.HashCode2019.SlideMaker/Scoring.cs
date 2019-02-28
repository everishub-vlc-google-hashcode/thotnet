namespace Thotnet.HashCode2019.SlideMaker
{
    public static class Scoring
    {
        public static int Min(Slide sl1, Slide sl2)
        {
            var min = 0;
            var score1 = sl1.Tags.Count;
            var score2 = sl2.Tags.Count;

            var commonScore = 0;

            foreach (var tag in sl1.Tags)
            {
                if (sl2.Tags.Contains(tag)) commonScore++;
                // if (commonScore > score1 || commonScore > score2) break;
            }

            if (score1 <= score2)
            {
                min = score1;
            }
            else
            {
                min = score2;
            }

            if (commonScore <= min)
            {
                return commonScore;
            }
            return min;
        }
    }
}
