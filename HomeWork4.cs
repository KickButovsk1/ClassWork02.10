using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку");
            string str = Console.ReadLine();
            str = str.Trim();
            if (str.Contains(" "))
            {
                str = str.Replace(" ", "");
            }
            int a = (str.Length);
            int b = a/2;
            string c = str.Substring(0, b);
            string d = str.Substring(b);
            string e = new string(d.Reverse().ToArray());
            if (c == e)
            {
                Console.WriteLine("строка палиндром");
            }
            else
            {
                Console.WriteLine("строка не палиндром");
            }
            Console.ReadKey();
        }
    }
    }
    
