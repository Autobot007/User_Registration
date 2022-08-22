using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class User
    {
        public static void ValidFirstName()
        {
            Console.WriteLine("Enter your first name");
            string data = Console.ReadLine();
            string namePattern = "^[A-Z]{1}[a-zA-Z]{2,}";
            Regex regex = new Regex(namePattern);
            if (regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Name is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Name is not Valid");
                Console.ResetColor ();
            }
        }
        
    }
}
