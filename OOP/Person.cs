using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Person
    {
        string firstName;
        string lastName;
        string eyeColor;
        int age;

        public Person()
        {
            Console.WriteLine("Object created.");
        }

        public Person(string FirstName, string LastName, string EyeColor)
        {
            firstName = FirstName;
            lastName = LastName;
            eyeColor = EyeColor;
        }

        public Person(string FirstName, string LastName, int Age    )
        {
            firstName = FirstName;
            lastName = LastName;
            age = Age;
        }

        public Person(string FirstName, string LastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }

        public Person(string FirstName)
        {
            firstName = FirstName;
        }
        //parameterized constructor
        public Person(string FirstName, string LastName, string EyeColor, int Age)
        {
            firstName = FirstName;
            lastName = LastName;
            eyeColor = EyeColor;
            age = Age;
        }
        public void Greetings()
        {
            if (age != 0 && firstName != null && lastName != null && eyeColor != null)
            {
                Console.WriteLine($"Hello, I'm {firstName} {lastName}, my eye color is {eyeColor} and " +
                $"I am {age} years old.");
            }
            else if (age != 0 && firstName != null && lastName != null)
            {
                Console.WriteLine($"Hello, I'm {firstName} {lastName}, and " +
                $"I am {age} years old.");
            }

            else if (age != 0 && lastName != null && eyeColor != null)
            {
                Console.WriteLine($"Hello, I'm {firstName}, my eye color is {eyeColor} and " +
                $"I am {age} years old.");
            }
            else if (age != 0 && lastName != null)
            {
                Console.WriteLine($"Hello, I'm {lastName},  and " +
                $"I am {age} years old.");
            }
            else
            {
                Console.WriteLine($"Hello, I'm {firstName} {lastName}, my eye color is {eyeColor}. ");
            }

        }
    }
}
