using System;

namespace OOP
{
    class OOP
    {
        static void Main(string[] args)
        {
            //instantiating a new person
            Person John = new Person("John", "Smith", "Blue", 50);
            John.Greetings();
            Person Smith = new Person("Smith", "Doe", "Green");
            Smith.Greetings();

            Person person = new Person();
            person.Greetings();

            Person Amy = new Person("Amy","", 35);
            Amy.Greetings();

            Console.ReadLine();
        }
    }
}
