using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the animal type: ");
            string animalType = Console.ReadLine();
            Console.Write("Please enter the animal sound: ");
            string animalSound = Console.ReadLine();

            Animals first = new Animals(animalType, animalSound);
            Console.WriteLine(first.AnimalSays());

           


            Console.ReadLine();

        }
    }
    class Animals
    {
        // properties 
        string animalnames;
        string animalnoises;

        //getters and setters 
        public string AnimalNames
        {
            get { return animalnames; }
            set { animalnames = value; }

        }
        public string AnimalNoises
        {
            get { return animalnoises; }
            set { animalnoises = value; }
        }

        public Animals(string _animalnames, string _animalnoises)
        {
            AnimalNames = _animalnames;
            AnimalNoises = _animalnoises;
        }

        // public method that returns a string 
        public string AnimalSays()
        {
            return "The " + AnimalNames + " says " + AnimalNoises;
        }

           
    }
}
