using System;
using System.Collections.Generic;
using System.Text;

namespace mod2_lab1
{
    class TechnicalEmployee : Employee
    {
        //base keyword will reuse constructor from parent class
        public TechnicalEmployee(String name) : base(name, 75000)
        {
        }
        public int successfulCheckIns = 5;

        //use override keyword to replace method in parent class
        public override string employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIns + " successful check ins";
        }
    }
}
