using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_activity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please type a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please type a second, larger number");
            int num2 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("for loop");
            for(int i = num1; i<=num2; i++)
            {
                Console.WriteLine("{0}       {1}       {2}", i, (i*10), (i*100)); 

            }

            int j = num1;
            Console.WriteLine("while loop");
            while (j <= num2)
            {
                Console.WriteLine("{0}       {1}       {2}", j, j*10,j*100);
                j++;

             }
            Console.WriteLine("do while loop");
            int k = num1;
            do
            {
                Console.WriteLine("{0}       {1}       {2}", k, k * 10, k * 100);
                k++;

            } while (k <= num2);
            Console.ReadLine();
        }
    }
}
