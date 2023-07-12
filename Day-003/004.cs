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
