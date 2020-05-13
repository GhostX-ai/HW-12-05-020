using System;
using System.Linq;

namespace HW12_05_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "hello";
            string newtext = String.Join("", text.ToCharArray().Select(p => p == 'a' ? "1" : p == 'e' ? "2" : p == 'i' ? "3" : p == 'o' ? "4" : p == 'u' ? "5" : p == 'y' ? "6" : p.ToString()));
            string lasttext = String.Join("", text.ToCharArray().Select(p => p == '1' ? "a" : p == '2' ? "e" : p == '3' ? "i" : p == '4' ? "o" : p == '5' ? "u" : p == '6' ? "y" : p.ToString()));
            Console.ReadKey();
        }
    }
}
