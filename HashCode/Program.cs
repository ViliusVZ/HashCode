using System;
using System.Collections.Generic;
using System.Linq;

namespace HashCode
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var allLines = System.IO.File.ReadAllLines(@"C:\Users\Laptop\Documents\Projektai\HashCode\HashCode\e_shiny_selfies.txt").ToList();

            var allPhotos = FileReader.GetAllPhotos(allLines);

            var temporaryListOfSlides = new List<Slide>();

            foreach (var photo in allPhotos)
            {
                if (allPhotos.Count(n => n.AlreadyUsed == false) > 0)
                {
                    temporaryListOfSlides.Add(SlideMaker.MakeSlide(allPhotos));
                }
                else
                {
                    break;
                }
            }

            var finalListOfSlides = new List<Slide>();

            foreach (var slide in temporaryListOfSlides)
            {
                if (slide.SlidePhotos.Count > 0)
                {
                    finalListOfSlides.Add(slide);
                }

            }

            var arrayOfRes = InterestCounter.GetResultString(finalListOfSlides);

            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\Laptop\Documents\Projektai\HashCode\HashCode\results.txt"))
            {
                foreach (var res in arrayOfRes)
                {
                    Console.WriteLine(res);
                    file.WriteLine(res);
                }
            }

            Console.ReadKey();
        }
    }
}