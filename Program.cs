using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            Car my_car = new Car
            {
                Suv = "Toyota Highlander 2013",
                Gtc = 19.2,
                Mpg = 21.8
            };
            Console.WriteLine(my_car.Suv); 
            Console.WriteLine(my_car.Gtc);
            Console.WriteLine(my_car.Mpg);
            DistanceIcanTravel();
            Console.ReadLine();

        }

        static void DistanceIcanTravel()
        {
            //get user input
            
            Console.WriteLine("Enter your car's GTC:");
            double tankCar= double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your car's MPG:");
            double millesPerGallon=double.Parse(Console.ReadLine());

            //calculate the distance you can travel with full tank

            double distance = tankCar * millesPerGallon;
            Console.WriteLine("The distance you can drive without running out of gas is:");
            Console.WriteLine(distance +" milles");

        }
    }
}
