using System.Collections.Generic;

namespace Thotnet.HashCode2019.SlideMaker
{
    public class Slide
    {
        public Slide(Photo ph1)
        {
            this.PhotoId1 = ph1.Id;
            this.PhotoId2 = -1;
            this.Tags = ph1.Tags;
        }
        public Slide(Photo ph1, Photo ph2)
        {
            this.PhotoId1 = ph1.Id;
            this.PhotoId2 = ph2.Id;
            var newTags = new List<string>();

            foreach (var tag in ph1.Tags)
            {
                newTags.Add(tag);
            }

            foreach (var tag in ph2.Tags)
            {
                newTags.Add(tag);
            }

            this.Tags = newTags;
        }

        public int PhotoId1 { get; set; }
        public int PhotoId2 { get; set; }
        public List<string> Tags { get; set; }
    }
}
