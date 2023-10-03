using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны прямоугольника через пробел");
            string str = Console.ReadLine();
            str = str.Trim();
            while (str.Contains("  "))
            {
                str = str.Replace("  ", " ");
            }
            string[] rez;
            rez = str.Split(' ');
            int a = str.Length;
            int b;
            bool p = int.TryParse(rez[0], out b);
            int c;
            bool p1 = int.TryParse(rez[1], out c);
            int x4 = b * c;
            if (p == true && p1 == true && a <= 3)
            {
                Console.WriteLine("Площадь: " + x4);
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();
        }
    }
}
