using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
             car1.Make = "Holden";
             car1.Model = "Commodore";
             car1.Colour = "Black";
             car1.Rego = "BHR143";

            Car car2 = new Car();
            car2.Make = "Mitsubishi";
            car2.Model = "Lancer";
            car2.Colour = "White";
            car2.Rego = "BHR143";

            Car car3 = new Car();
            car3.Make = "BMW";
            car3.Model = "M5";
            car3.Colour = "Grey";
            car3.Rego = "BHR143";

            Car car4 = new Car();
            car4.Make = "Audi";
            car4.Model = "idk many car models";
            car4.Colour = "Black";
            car4.Rego = "BHR143";

            Car car5 = new Car();
            car5.Make = "Honda";
            car5.Model = "Alteza";
            car5.Colour = "Red";
            car5.Rego = "BHR143";



            Car[] carCollection = new Car[5];
            carCollection[0] = car1;
            carCollection[1] = car2;
            carCollection[2] = car3;
            carCollection[3] = car4;
            carCollection[4] = car5;



            Console.WriteLine(carCollection[0].GetAllDetails());
            Console.WriteLine(carCollection[1].GetAllDetails());
            Console.WriteLine(carCollection[2].GetAllDetails());
            Console.WriteLine(carCollection[3].GetAllDetails());
            Console.WriteLine(carCollection[4].GetAllDetails());


            Console.ReadLine();
        }
    }
    class Car 
    {
        string make;
        string model;
        string colour;
        string rego;
        public string Make
        {
            get  { return make; } 
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public string Rego 
        {
            get { return rego; }
            set { rego = value; }
        }
        //public Car(string _make, string _model, string _colour, string _rego)
        //{
        //    Make = _make;
        //    Model = _model;
        //    Colour = _colour;
        //    Rego = _rego;
        //}
        public string GetAllDetails()
        {
            return Make + " " + Model +" "+ Colour +" "+ Rego;
        }
    }
}
