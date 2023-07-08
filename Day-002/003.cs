using System;

namespace Project03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My C# Adventure"; // can change console title 
            Console.Write("Enter the first number : ");
            //We convert from string to integer
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 + number2;
            Console.Write("The sum of the numbers : " + result);

            Console.ReadLine();
        }
    }
}
