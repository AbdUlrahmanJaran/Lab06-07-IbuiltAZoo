using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbuiltAZoo.Classes
{
    public abstract class Bird : Animal
    {
        public string Color { get; set; }

        public virtual void Fly()
        {
            Console.WriteLine("Bird is Flying");
        }
    }

    public class Chicken : Bird
    {
        public override string Eat()
        {
            return "Chicken is Eating";
        }
        public override string Sound()
        {
            return "Chicken Sound: Cha-Caw";
        }
        public override string Sleep()
        {
            return "Chicken is Sleeping";
        }

        public override void Fly()
        {
            Console.WriteLine("Chicken is Flying");
        }
    }

    public class Owl : Bird
    {
        public override string Eat()
        {
            return "Owl is Eating";
        }
        public override string Sound()
        {
            return "Owl Sound: Hoot";
        }
        public override string Sleep()
        {
            return "Owl is Sleeping";
        }

        public override void Fly()
        {
            Console.WriteLine("Owl is Flying");
        }
    }
}
