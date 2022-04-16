using System;
using IbuiltAZoo.Classes;

namespace IbuiltAZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Zoo");
            Bird chicken = new Chicken();
            chicken.Fly();
            Console.WriteLine(chicken.Sleep());
            chicken.Color = "White";
            Console.WriteLine(chicken.Color);

            Mammal giraffe = new Giraffe();
            Console.WriteLine(giraffe.Eat());
            giraffe.Walk(); // Giraffe doesn't override Walk() so Mammal Walk() will run
            
            Giraffe giraffe2 = new Giraffe();
            Console.WriteLine(giraffe2.Grind());
        }
    }
}
