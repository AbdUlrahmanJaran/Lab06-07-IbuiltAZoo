using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbuiltAZoo.Classes
{
    public abstract class Mammal : Animal
    {
        public string Gender { get; set; }
        public int Speed { get; set; }

        public virtual void Walk()
        {
            Console.WriteLine("Mammal is Walking");
        }
    }

    public class Lion : Mammal
    {
        public override string Eat()
        {
            return "Lion is Eating";
        }
        public override string Sound()
        {
            return "Lion Sound: Roar";
        }
        public override string Sleep()
        {
            return "Lion is Sleeping";
        }

        public override void Walk()
        {
            Console.WriteLine("Lion is Walking");
        }
    }

    public class Giraffe : Mammal
    {
        public override string Eat()
        {
            return "Giraffe is Eating";
        }
        public override string Sound()
        {
            return "Giraffe Sound: Bleat";
        }
        public override string Sleep()
        {
            return "Giraffe is Sleeping";
        }
    }
}
