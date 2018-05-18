using System;
using System.Collections.Generic;
using System.Text;

namespace EdX_Cs_OOP
{
    class DrinksMachine
    {
        //Auto-implemented member variables
        private int _age;
        public int Age { get => _age; set => _age = value; }

        private string _make;
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        private string _model;
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private string _location; //this is the variable
        public string Location //this is the property
        {
            get { return _location; }
            set { _location = value; }
        }

        

        //default constructor
        public DrinksMachine()
        {
            Age = 0;
        }
        //Constructors
        public DrinksMachine(int age)
        {
            this.Age = age;
        }
        public DrinksMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model;
        }
        public DrinksMachine(int age, string make, string model)
        {
            this.Age = age;
            this.Make = make;
            this.Model = model;
        }
        public void MakeCappuccino()
        {
            //method for cappos go here, dood
            Console.WriteLine("I made you a cappo, dood.");
        }
        public void MakeEspresso()
        {
            //its pronounced "espresso" not "expresso", dipshit
        }
    }
}
