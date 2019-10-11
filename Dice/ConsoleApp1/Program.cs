using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Exp(Math.Log(10) * 4));
            Console.WriteLine(Max(4, 2, 5, 1));

        }
        public static int Max(int a, int b)
        {
            return Math.Max(a, b);
        }
        public static int Max(int a, int b, int c)
        {
            return Math.Max(Max(a, b),c);
        }
            public static int Max(int a, int b, int c, int d)
        {
            return Max(Max(a, b, c),d);
        }
    }
}
