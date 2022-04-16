using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbuiltAZoo.Classes
{
    public abstract class Animal
    {
        private int age;
        private int length;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public abstract string Eat();
        public abstract string Sound();
        public abstract string Sleep();
    }
}
