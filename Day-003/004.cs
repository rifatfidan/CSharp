using System;

namespace Project05
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string names,school,work,age,birthDate;
            Console.Write("Your name and surname...................:");
            names=Console.ReadLine();
            Console.Write("Your school.............................:");
            school=Console.ReadLine();
            Console.Write("Your work...............................:");
            work=Console.ReadLine();
            Console.Write("Your age................................:");
            age=Console.ReadLine();
            Console.Write("Your birth..............................:");
            birthDate=Console.ReadLine();

            Console.WriteLine();
            Console.Write("Your Information........................:");
            Console.Write("Your name and surname...................:"+names);
            Console.Write("Your school.............................:"+school);
            Console.Write("Your work...............................:"+work);
            Console.Write("Your age................................:"+age);
            Console.Write("Your birth..............................:"+birthDate);

            Console.ReadLine();
            

        }
    }
}
