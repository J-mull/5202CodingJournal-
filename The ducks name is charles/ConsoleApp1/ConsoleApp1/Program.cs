using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an animal type: ");
            string anName = Console.ReadLine();
            Console.Write("Please enter the animals name: ");
            string anType = Console.ReadLine();

            Animal a1 = new Animal(anName, anType);
            Console.WriteLine(a1.show());

            Console.ReadLine();
        }
    }
    class Animal
    {
        public string type;
        public string name;
        public int id;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Animal(string _type, string _name)
        {
            Type = _type;
            Name = _name;
          
            
        }

        public string show()
        {
            return $" {Name} is a {Type}";
        }

    
    }
        



    }

