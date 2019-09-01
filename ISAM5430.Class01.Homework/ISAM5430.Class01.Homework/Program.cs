using System;

namespace ISAM5430.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            string input = Console.ReadLine(); // prompts user to input a number as a string
            int num1 = Convert.ToInt32(input); //converts string to interval stores input as a number with to variable num1
            Console.WriteLine("Enter number 2");
            input = Console.ReadLine(); // prompts user to input a number as a string
            int num2 = Convert.ToInt32(input); //converts string to interval stores input as a number with to variable num1
            Console.WriteLine("Enter the operator: (+, -, /, *)");
            string op = Console.ReadLine(); //saves user input to variable op for use with calculation

            if (op == "+")
            {
                // declare an int variable sum.
                // assign the sum of num1 + num2 into the sum variable.
                // print the sum of num1 + num2.,
                int sum = num1 + num2;
                Console.WriteLine($"The answer is: {sum}");


            }
            if (op == "-")
            {
                int sub = num1 - num2;
                Console.WriteLine($"The answer is: {sub}");
            }
            if (op == "*")
            {
                int mult = num1 * num2;
                Console.WriteLine($"The answer is: {mult}");
            }
            if (op == "/")
            {
                int div = num1 / num2;
                Console.WriteLine($"The answer is: {div}");
            }

            else 
            {
           Console.WriteLine("You must select numbers and operators.");
            }
        }
    }
}
