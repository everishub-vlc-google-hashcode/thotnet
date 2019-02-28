using System;
using System.Collections.Generic;
using System.Text;

namespace Thotnet.HashCode2019.Runner
{
    public class Photo
    {
        public bool IsVertical { get; set; }
        public int TagCount { get; set; }
        public IEnumerable<string> TagList { get; set; }
    }
}
