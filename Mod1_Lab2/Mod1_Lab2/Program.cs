using System;

namespace Mod1_Lab2
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

    public class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        //if only color & year are given
        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            instances++;
        }

        //if only year & mileage are given
        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            instances++;
        }

        //static class that tracks inventory
        private static int instances = 0;

        //default constructor if no arguments are passed
        public Car()
        {
            instances++;
        }
        public static int CountCars()
        {
            return instances;
        }
    }
}
