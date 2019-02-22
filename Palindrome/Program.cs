using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        //Check if the word is palindrome
        public static bool IsPalindrome(string palabra)
        {
            palabra = palabra.ToLower();
            int min = 0;
            int max = palabra.Length - 1;
            while (min > max)
            {

                char a = palabra[min];
                char b = palabra[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
            return true;
        }

        static void Main()
        {
            Console.WriteLine("Dime la palabra: ");
            string palabra = Console.ReadLine();
            if (IsPalindrome(palabra))
            {
                Console.WriteLine("Sí es.");
            }
            else
            {
                Console.WriteLine("No lo es.");
            }
            Console.ReadKey();
        }
    }
}
