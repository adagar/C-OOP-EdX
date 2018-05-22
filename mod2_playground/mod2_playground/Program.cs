using System;

namespace mod2_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Manager leadManager = new Manager();
            leadManager.Login();
            leadManager.Hire();
        }
    }
}
