using System.Collections.Generic;

namespace HashCode
{
    public class Slide
    {
        public List<Photo> SlidePhotos { get; set; } = new List<Photo>();
        public bool IsValid { get; set; } = false;
    }
}