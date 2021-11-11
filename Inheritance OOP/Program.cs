using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("rouge", 15);
            Console.WriteLine($"{dog.Name} and {dog.Age}");
            dog.MakeSound();
            dog.Play();
            dog.Eat();

            Console.Read();
        }

    }
}
