using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbuiltAZoo.Classes
{
    public abstract class SeaAnimal : Animal
    {
        public string Size { get; set; }

        public virtual void Swim()
        {
            Console.WriteLine("SeaAnimal is Swimming");
        }
    }

    public class Fish : SeaAnimal
    {
        public string Type { get; set; }

        public override string Eat()
        {
            return "Fish is Eating";
        }
        public override string Sound()
        {
            return "Fish Sound: Drumming";
        }
        public override string Sleep()
        {
            return "Fish is Sleeping";
        }

        public override void Swim()
        {
            Console.WriteLine("Fish is Swimming");
        }
    }

}
