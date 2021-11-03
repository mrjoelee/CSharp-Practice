using System;

namespace Switch
{
    class Program
    {
        static int score;
        static int highScore = 10;
        static string highScorePlayer = "King";
        static string playerName;

        static void Main(string[] args)
        {
            Score(score,playerName);     
            Console.Read();
        }
        static void Score(int score, string playerName)
        {
            Console.WriteLine("Please enter score: ");
            score = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter PlayerName: ");
            playerName = Console.ReadLine();

            if(score > highScore)
            {
                Console.WriteLine($"New HighScore is {score}");
                Console.WriteLine($"New HighScore holder is {playerName}");
            }
            else
            {
                Console.WriteLine($"The old high-score of {highScore} could be broken and still held by {highScorePlayer}");
            }
            Console.WriteLine("Try again!");
        }
    }
}
