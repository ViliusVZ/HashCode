using System.Collections.Generic;

namespace HashCode
{
    public static class SlideMaker
    {
        public static Slide MakeSlide(List<Photo> listOfPhotos)
        {
            var slide = new Slide();
            bool lookingForVertical = false;

            foreach (var photo in listOfPhotos)
            {
                if (photo.AlreadyUsed == false &&
                    photo.Orientation == 'V' &&
                    slide.SlidePhotos.Count < 2)
                {
                    slide.SlidePhotos.Add(photo);
                    photo.AlreadyUsed = true;
                    lookingForVertical = true;
                }
                else if (photo.AlreadyUsed == false &&
                         photo.Orientation == 'H' &&
                         lookingForVertical == false)
                {
                    slide.SlidePhotos.Add(photo);
                    photo.AlreadyUsed = true;
                    return slide;
                }
            }

            return slide;
        }
    }
}