using System;
using System.Collections.Generic;
using System.Text;

namespace Mod1_Lab3
{
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
