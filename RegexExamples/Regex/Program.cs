using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Preface the regex pattern with a @ so you don't need escape characters for 
            // sequences like \d
            Regex starIdRegex = new Regex(@"^[a-z]{2}\d{4}[a-z]{2}$");

            string example1 = "aa1234cd";

            if (starIdRegex.IsMatch(example1))
            {
                Console.WriteLine(example1 + " is a valid StarID");   // this is printed
            }
            else
            {
                Console.WriteLine(example1 + " is NOT a valud StarID");
            }

            string example2 = "12abcd34";

            if (starIdRegex.IsMatch(example2))
            {
                Console.WriteLine(example2 + " is a valid StarID");
            }
            else
            {
                Console.WriteLine(example2 + " is NOT a valid StarID");  // this is printed
            }

            Console.ReadKey();

        }
    }
}
