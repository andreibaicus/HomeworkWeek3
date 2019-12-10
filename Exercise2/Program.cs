using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = null;
            string string2 = "hello";

            Console.WriteLine("enter a string: ");
            string1 = Console.ReadLine();
            
            if (string.IsNullOrEmpty(string1))
            {
                Console.WriteLine("string1 is null or empty.");
            }
            else
            {
                Console.WriteLine("string1 = " + string1);
            }

            if (string.Compare(string1.ToLower(), string2.ToLower()) == 0)
            {
                Console.WriteLine("Strings have the same value.");
            }
            else if (string.Compare(string1.ToLower(), string2.ToLower()) > 0)
            {
                Console.WriteLine("string1 > string2");
            }
            else
            {
                Console.WriteLine("string1 < string2");
            }

            string string3 = string.Concat(string2, string1);
            string searchString = "world";

            if (string3.Contains(searchString))
            {
                Console.WriteLine("string3 contains " + searchString);
            }
            else
            {
                Console.WriteLine("string3 don't contains " + searchString);
            }

            Console.WriteLine(string3.IndexOf(string1));

            Console.WriteLine(string3.Trim().ToUpper());
        }
    }
}
