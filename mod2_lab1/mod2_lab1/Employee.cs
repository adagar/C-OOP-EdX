using System;
using System.Collections.Generic;
using System.Text;

namespace mod2_lab1
{
    abstract class Employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;
        //has static, similar to a static class. So when this changes in this instance, it will change for all
        private static int employeeCount = 1;

        public string Name { get => employeeName; set => employeeName = value; }
        public double BaseSalary { get => employeeBaseSalary; set => employeeBaseSalary = value; }
        public int ID { get => employeeId; set => employeeId = value; }

        //constructor
        public Employee(String name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }

        //getters
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }
        public String getName()
        {
            return this.Name;
        }
        public int getEmployeeID()
        {
            return this.ID;
        }
        public String toString()
        {
            return this.ID + " " + this.Name;
        }

        //virtual so it's easily overwritten in subclasses
        public abstract String employeeStatus();
    }
}
