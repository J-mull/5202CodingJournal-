using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[5];

            Console.Write("Please enter the first name: ");
            name[0] = Console.ReadLine();
            Console.Write("Please enter the second name: ");
            name[1] = Console.ReadLine();
            Console.Write("Please enter the third name: ");
            name[2] = Console.ReadLine();
            Console.Write("Please enter the fourth name: ");
            name[3] = Console.ReadLine();
            Console.Write("Please enter the fifth name: ");
            name[4] = Console.ReadLine();

            Console.WriteLine($"The first name is: {name[0]}");
            Console.WriteLine($"The last name is: {name[4]}");

            Console.ReadLine();


        }
    }
}
