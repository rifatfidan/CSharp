using System;

namespace Project04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "UsingFormat";
            string author = "Richard Bounce";
            string book = "Learning C#";
            int year = 2023;
            decimal price = 158.95m;
            string publisher = "Fidan Press";

            string bookDetails = String.Format("{0} is the author of book {1} \npublished by {2} in year {3}. \n"
            + "Book price is {4}. ", author, book, publisher, year, price);
            Console.WriteLine(bookDetails);
            Console.ReadLine();
            

        }
    }
}
