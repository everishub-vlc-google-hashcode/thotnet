using System.Collections.Generic;

namespace Thotnet.HashCode2019.SlideMaker
{
    public class Slide
    {
        public Slide(Photo ph1)
        {
            this.PhotoId1 = ph1.Id;
            this.Tags = ph1.Tags;
        }
        public Slide(Photo ph1, Photo ph2)
        {
            this.PhotoId1 = ph1.Id;
            this.PhotoId2 = ph1.Id;

            this.Tags = ph1.Tags;
            if (ph2.Tags != null)
            {
                foreach (var tag in ph2.Tags)
                {
                    this.Tags.Add(tag);
                }
            }
        }

        public int PhotoId1 { get; set; }
        public int PhotoId2 { get; set; }
        public List<string> Tags { get; set; }
    }
}
