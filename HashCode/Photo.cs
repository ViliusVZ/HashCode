using System.Collections.Generic;

namespace HashCode
{
    public class Photo
    {
        public char Orientation { get; set; }
        public int TagCount { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
    }
}