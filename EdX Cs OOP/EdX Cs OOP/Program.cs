using System;

namespace EdX_Cs_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DrinksMachine dm = new DrinksMachine("Folgers", "Caffo Blasto");
            dm.Location = "Kitchen";
            dm.MakeCappuccino();

            Console.WriteLine(dm.Location);

        }
    }
}
