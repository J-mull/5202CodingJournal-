using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a radius of a circle in centimeters: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The circumference of the circle is {ConvertToCircumference(radius)}cm");
            Console.WriteLine($"The area of the circle is {ConvertToArea(radius)}cm^2");

            Console.ReadLine();

        }

        public static double ConvertToCircumference(double radius)
        {
           
            return radius * (2*3.14159); 
        }
        public static double ConvertToArea(double radius)
        {
            return (radius* radius) * 3.14159;
        }
    }
}
