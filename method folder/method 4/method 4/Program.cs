using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "mon", "tues", "wed", "thur", "fri", "sat", "sun" };
            Console.Write("please enter a number and i will tell you the coresponding day: ");
            int input = int.Parse(Console.ReadLine());
            CheckDay(input, days);

            Console.ReadLine();
        }

        public static void CheckDay(int input, string[] days)
        {
            Console.WriteLine($"The number you entered is a: {days[input -1]}");
        }
    }
}
