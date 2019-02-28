using System;
using System.Collections.Generic;

namespace HashCode
{
    public static class FileReader
    {
        public static List<Photo> GetAllPhotos(List<string> listFromFile)
        {
            var listOfPhotos = new List<Photo>();
            string[] splitArray = { };

            for (int j = 1; j < listFromFile.Count; j++)
            {
                var photo = new Photo();

                splitArray = listFromFile[j].Split(' ');

                photo.Orientation = Convert.ToChar(splitArray[0]);
                photo.TagCount = Convert.ToInt32(splitArray[1]);

                for (int i = 2; i < photo.TagCount + 2; i++)
                {
                    photo.Tags.Add(splitArray[i]);
                }

                listOfPhotos.Add(photo);
            }

            return listOfPhotos;
        }
    }
}