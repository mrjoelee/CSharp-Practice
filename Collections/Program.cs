using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ////creating an array datatype[] arrayname;

            //int[] Paygrades;

            //int[] mathGrades = { 50, 20, 60, 90 };

            ////in order to initialize an array
            ////dataytpe[] arrayname = new datatype[amount of entires];

            ////faster than foreach
            //int[] grades = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    grades[i] = i + 10;

            //}


            //int counter = 0;
            //foreach (var k in grades)
            //{
            //    Console.WriteLine($"{counter}, {k}");
            //    counter++;
            //}
            //Console.Read();

            //for (int j = 0; j < 10; j++)
            //{
            //    Console.WriteLine($"");
            //}

            //create an array with 5 friends
            //create a foreach loop which greets all of them
            //string[] bestFriend = { "Joe", "Smith", "John", "Amy", "Michael" };

            //foreach (string name in bestFriend)
            //{
            //    Console.WriteLine($"Hello {name}");
            //}

            //Console.Read();


            bool valid = false;

            string inputvaluetype = string.Empty;

            Console.WriteLine("Enter a value: ");
            string inputvalue = Console.ReadLine();

            Console.WriteLine("Select the Data type to validate the input you have entered:");
            Console.WriteLine("Press 1 for string");
            Console.WriteLine("Press 2 for int");
            Console.WriteLine("Press 3 for Boolean");

            Console.WriteLine("Enter :");
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch (inputType)
            {
                case 1:
                    valid = isAllAlphabetic(inputvalue);
                    inputvaluetype = "String";
                    break;

                case 2:
                    int retValue = 0;
                    valid = int.TryParse(inputvalue, out retValue);
                    break;

                case 3:
                    bool retflag = false;
                    valid = bool.TryParse(inputvalue, out retflag);
                    inputvaluetype = "Boolean";
                    break;

                default:

                    Console.WriteLine("Not able to detect the type, something is wrong");
                    break;
            }
            Console.WriteLine($"You have entered {inputvalue}");
            if (valid)
            {
                Console.WriteLine($"It is valid {inputvaluetype}");
            }
            else
            {
                Console.WriteLine($"It is an invalid {inputvaluetype}");
            }
            Console.Read();

        }

        static  bool isAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true; 
        }
    }
}
