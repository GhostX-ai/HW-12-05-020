using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW12_05_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "hello";
            string newtext = String.Join("", text.ToCharArray().Select(p => p == 'a' ? "1" : p == 'e' ? "2" : p == 'i' ? "3" : p == 'o' ? "4" : p == 'u' ? "5" : p == 'y' ? "6" : p.ToString()));
            Console.WriteLine(newtext);
            string lasttext = String.Join("", text.ToCharArray().Select(p => p == '1' ? "a" : p == '2' ? "e" : p == '3' ? "i" : p == '4' ? "o" : p == '5' ? "u" : p == '6' ? "y" : p.ToString()));
            Console.WriteLine(lasttext);
            string word = "gdfgdf234dg54gf*23oP42";
            int x = 0;
            string clear = String.Join("", word.ToCharArray().Select(p => int.TryParse(p.ToString(), out x) == true ? p.ToString() : p == '+' || p == '-' || p == '*' || p == '/' ? p.ToString() : ""));
            string func = String.Join("", clear.ToCharArray().Select(p => int.TryParse(p.ToString(), out x) == true ? "" : p == '+' || p == '-' || p == '*' || p == '/' ? p.ToString() : ""));
            var z = clear.Split(func);
            x = int.Parse(z[0]);
            int y = int.Parse(z[1]);
            int res = 0;
            res = func == "+" ? x + y : func == "-" ? x - y : func == "*" ? x * y : func == "/" ? x / y : 0;
            Console.WriteLine(clear);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
