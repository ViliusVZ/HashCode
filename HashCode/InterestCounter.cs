using System.Collections.Generic;

namespace HashCode
{
    public static class InterestCounter
    {
        public static string[] GetResultString(List<Slide> slides)
        {
            string[] arrayOfResults = new string[slides.Count + 1];
            arrayOfResults[0] = slides.Count.ToString();

            for (int i = 1; i < slides.Count + 1; i++)
            {
                if (slides[i - 1].SlidePhotos.Count == 2)
                {
                    arrayOfResults[i] = slides[i - 1].SlidePhotos[0].id + " " + slides[i - 1].SlidePhotos[1].id;
                }
                else
                {
                    arrayOfResults[i] = slides[i - 1].SlidePhotos[0].id.ToString();
                }
            }

            return arrayOfResults;
        }
    }
}