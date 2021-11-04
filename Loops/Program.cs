using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while (input != "-1;")
            {
                Console.WriteLine($"Last number was {currentNumber}");
                Console.WriteLine("Please enter the next score");
                Console.WriteLine($"Current amount of entires {count}");
                Console.WriteLine("Please enter -1 once  you are ready to  calculate the average");

                input = Console.ReadLine();
                if(input == "-1")
                {
                    Console.WriteLine("---------------------------");
                    double average = (double)total / (double)count;
                    Console.WriteLine($"The average score is {average}");
                    break;
                }
                if(int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                {
                    total = total + currentNumber;
                }
                else
                {
                    if(input != "-1")
                    {
                        Console.WriteLine("Please enter a value between 1 and 20");
                    }
                    continue;
                }
                count++;
            }
            Console.Read();

             
        }

    }
}
