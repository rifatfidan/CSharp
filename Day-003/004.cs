using System;

namespace Project05
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string names,school,work,age,birthDate;
            Console.WriteLine("Your name and surname...................:");
            names=Console.ReadLine();
            Console.WriteLine("Your school.............................:");
            school=Console.ReadLine();
            Console.WriteLine("Your work...............................:");
            work=Console.ReadLine();
            Console.WriteLine("Your age................................:");
            age=Console.ReadLine();
            Console.WriteLine("Your birth..............................:");
            birthDate=Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Your Information........................:");
            Console.WriteLine("Your name and surname...................:"+names);
            Console.WriteLine("Your school.............................:"+school);
            Console.WriteLine("Your work...............................:"+work);
            Console.WriteLine("Your age................................:"+age);
            Console.WriteLine("Your birth..............................:"+birthDate);

            Console.ReadLine();
            

        }
    }
}
