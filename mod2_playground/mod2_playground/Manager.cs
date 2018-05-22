using System;
using System.Collections.Generic;
using System.Text;

namespace mod2_playground
{
    class Manager : Employee
    {
        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        //this was a virtual class so this was optional
        public override void Login()
        {
            Console.WriteLine("Manager login");
        }

        //this MUST be here since its an abstract method
        public override void Hire()
        {
            Console.WriteLine("Hire someone...");
        }
    }
}
