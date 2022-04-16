using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbuiltAZoo.Classes
{
    public abstract class Pet : Animal
    {
        string Name { get; set; }
        
        public virtual void Jump()
        {
            Console.WriteLine("Pet is Jumping");
        }
        public virtual void Play()
        {
            Console.WriteLine("Pet is Playing");
        }
    }

    public class Cat : Pet
    {
        public string type { get; set; }

        public override string Eat()
        {
            return "Cat is Eating";
        }
        public override string Sound()
        {
            return "Cat Sound: Meow";
        }
        public override string Sleep()
        {
            return "Cat is Sleeping";
        }

        public override void Jump()
        {
            Console.WriteLine("Cat is Jumping");
        }
        public override void Play()
        {
            Console.WriteLine("Cat is Playing");
        }
    }
}
