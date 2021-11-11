using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_OOP
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            IsHungry = true;    
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }

        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}
