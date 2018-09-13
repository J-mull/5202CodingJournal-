using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"The input {number} changed is: {ChangeSign(number)}");

            Console.ReadLine();
        }


        public static int ChangeSign(int number)
        {
            return number * -1;
        }
        
    }
    
}
