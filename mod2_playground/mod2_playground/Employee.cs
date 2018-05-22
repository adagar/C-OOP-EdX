using System;
using System.Collections.Generic;
using System.Text;

namespace mod2_playground
{
    abstract class Employee
    {
        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;

        public string EmpNumber
        {
            get
            {
                return empNumber;
            }
            set
            {
                empNumber = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        
        //virtual classes can be overridden in subclasses OR used
        public virtual void Login()
        {
            Console.WriteLine("Logged in!");
        }
        public virtual void LogOff()
        {

        }

        public abstract void Hire();
        //abstract decorator:
            //CANNOT exist in non-abstract class
            //no implementation
            //must end in semi-colon
            //MUST be implemented in sub-class
        //public abstract void EatLunch();
    }
}
