using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // Labas
            // Paulius
            //Justas
            //Tadas



            //rusiavimas tagu ir skaiciavimas, Paulius

            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Paulius\Documents\hashcode\HashCode\HashCode\b_lovely_landscapes.txt");


            int number_of_lines = Convert.ToInt32( lines[0]);
            System.Console.WriteLine("number of lines  = ");
            System.Console.WriteLine(Convert.ToString(number_of_lines));

            

            int[] number_of_tags_in_photo = new int [1000];

            for (int i = 1; i < number_of_lines; i++)
            {

            }



            foreach (string line in lines)
            {
                
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }



    }
    
}
