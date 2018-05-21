using System;

namespace Mod1_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var Car1 = new Car();

            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            //Console.WriteLine($"This car is painted {Car1.Color}, was built in {Car1.Year}, and has {Car1.Mileage} miles on it.");
            //create a car with the constructor
            var Car2 = new Car("Red", 2008);

            int carCount = Car.CountCars();
            Console.WriteLine($"There are current {carCount} cars on inventory.");
        }
    }
}