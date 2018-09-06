using System;

namespace harder_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            Console.WriteLine("please enter 5 numbers");
            Console.Write("first number: ");
            num[0] = int.Parse(Console.ReadLine());
            Console.Write("second number: ");
            num[1] = int.Parse(Console.ReadLine());
            Console.Write("third number: ");
            num[2] = int.Parse(Console.ReadLine());
            Console.Write("fourth number: ");
            num[3] = int.Parse(Console.ReadLine());
            Console.Write("fifth number: ");
            num[4] = int.Parse(Console.ReadLine());

            Console.WriteLine("Your five numbers");
            
            for (int i = 0; i < num[4] ; i++) 
            {
                Console.WriteLine(num[i]);

            }
            Console.WriteLine("Your five numbers in reverse");
            for (int i = 4; i >= num[0]; i --)
            {
                Console.WriteLine(num[i]);

            }
            Console.WriteLine(num[0]);
            Console.ReadLine();
        }
    }
}
