﻿using System.Collections.Generic;

namespace Thotnet.HashCode2019.SlideMaker
{
    public class Photo
    {
        public int Id { get; set; }
        public bool IsVertical { get; set; }
        public List<string> tags { get; set; }
    }
}
