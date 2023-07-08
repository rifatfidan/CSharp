using System;

namespace Project02
{
    class Program
    {
        static void Main(string[] args)
        {

            string name; // create a string for Readline()
            Console.Write("Input your name and surname please : ");
            name = Console.ReadLine();
            Console.Write("Your name is : " + name);// We combine string and variant with +    
            Console.ReadLine();
        }
    }
}



