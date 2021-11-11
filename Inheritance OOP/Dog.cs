using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_OOP
{
    internal class Dog : Animal
    {
        public bool IsHappy { get; set; }
        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }

        //overriding the virtual method from the parent class "animal"
        public override void Eat()
        {
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Wuff!.");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}
