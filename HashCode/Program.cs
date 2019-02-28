using System.Linq;

namespace HashCode
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var allLines = System.IO.File.ReadAllLines(@"C:\Users\viliu\Desktop\HashCode\HashCode\HashCode\a_example.txt").ToList();

            var allPhotos = FileReader.GetAllPhotos(allLines);
        }
    }
}