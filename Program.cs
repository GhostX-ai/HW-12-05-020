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
            Console.ReadKey();
        }
    }
}
