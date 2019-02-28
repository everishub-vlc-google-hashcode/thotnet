namespace Thotnet.HashCode2019.SlideMaker
{
    public static class Scoring
    {
        public static int Min(Slide sl1, Slide sl2)
        {
            var score1 = sl1.Tags.Count;
            var score2 = sl2.Tags.Count;

            var commonScore = 0;

            foreach (var tag in sl1.Tags)
            {
                if (sl2.Tags.Contains(tag)) commonScore++;
            }

            if (score1 <= score2 && score1 <= commonScore) return score1;
            else if (score2 <= score1 && score2 <= commonScore) return score2;
            else return commonScore;
        }
    }
}
