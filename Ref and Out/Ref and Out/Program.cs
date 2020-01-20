using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_and_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            string message = MakeGreeting(name);
            Console.WriteLine(message);

            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();
            int nameLength = FullName(name, lastName, out string fullname);
            Console.WriteLine("Your full name is " + fullname + ". It has this many letters: " + nameLength);

            Capitalize(ref fullname);
            Console.WriteLine("Your name in uppercase: " + fullname);
            
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static string MakeGreeting(string name)
        {
            return "Hello " + name + "!!";
        }  // This method is collapsed to save space

        static int FullName(string firstName, string lastName, out string fullName)
        {
            fullName = firstName + " " + lastName;
            return fullName.Length;
        }

        static void Capitalize(ref string fullname)
        {
            fullname = fullname.ToUpper();
        }

    }
}


