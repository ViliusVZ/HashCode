using System.Collections.Generic;

namespace HashCode
{
    public class Photo
    {
        public char Orientation { get; set; }
        public int TagCount { get; set; }
        public List<Tag> Tags { get; set; }

        public Photo(char _orientation, List<Tag> _tags)
        {
            Orientation = _orientation;
            Tags = _tags;
            TagCount = Tags.Count;
        }
    }
}