using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int num1 = Convert.ToInt32(input);
            Console.WriteLine("Enter another number");
            input = Console.ReadLine();
            int num2 = Convert.ToInt32(input);
            Console.WriteLine("Choose +,-,*,/");
            string op = Console.ReadLine();

            if (op=="+")
            {
                int sum = num1 + num2;
                Console.WriteLine($"The answer is: {sum}");
            }
            if (op=="-")
            {
                int sub = num1 - num2;
                Console.WriteLine($"The andwer is:{sub}");
            }
            if (op=="*")
            {
                int mult = num1 * num2;
                Console.WriteLine($"The answer is:{mult}");
            }
            if (op=="/")
            {
                int div = num1 / num2;
                Console.WriteLine($"The answer is:{div}");
            }
            else
            {
                Console.WriteLine("You must choose numbers and mathmatical options.");
            }

        }
    }
}
