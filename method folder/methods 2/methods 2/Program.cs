using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a distance in miles: ");
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine($"Your distance converted to kilometers is {Convert(miles)} ");
            Console.ReadLine();
        }


        public static double Convert(double miles)
        {
            return miles * 1.62137;
        }
    }
}
