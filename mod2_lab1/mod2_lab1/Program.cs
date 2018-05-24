using System;

namespace mod2_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's test this bad boy!");

            var employee1 = new TechnicalEmployee("Libby");
            var employee2 = new TechnicalEmployee("Zaynah");
            var employee3 = new BusinessEmployee("Winter");
            Console.WriteLine(employee1.employeeStatus() + " .... " + employee2.employeeStatus() + " .... " + employee3.employeeStatus());
        }
    }
}
