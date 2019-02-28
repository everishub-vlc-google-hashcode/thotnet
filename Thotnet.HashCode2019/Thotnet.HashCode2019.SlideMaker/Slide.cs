using System.Collections.Generic;

namespace Thotnet.HashCode2019.SlideMaker
{
    public class Slide
    {
        public Slide(Photo ph1)
        {
            this.PhotoId1 = ph1.Id;
        }
        public Slide(Photo ph1, Photo ph2)
        {
            this.PhotoId1 = ph1.Id;
            this.PhotoId2 = ph1.Id;
        }

        public int PhotoId1 { get; set; }
        public int PhotoId2 { get; set; }
        public List<string> Tags { get; set; }
    }
}
