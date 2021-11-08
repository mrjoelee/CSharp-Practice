using System;

namespace UsingArray_TicTacToe
{
    class Program
    {
        //variables for the playfield
        static char[,] playField =
        {
            {'1', '2', '3' },
            {'4', '5', '6' },
            {'7', '8', '9' }
        };
        static void Main(string[] args)
        {
            //player 1 starts
            int player = 2;
            int input = 0;
            bool inputCorrect = true;

            //Run code as long as the program runs (restarting the game) 
            do
            {
                

                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if ( player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                SetField();
                do
                {
                    Console.WriteLine($"Player {player}: Choose you field");
                    input = Convert.ToInt32(Console.ReadLine());

                } while (!inputCorrect);

            } while (true);


        }

        public static void SetField()
        {
            Console.Clear();

            Console.WriteLine("     |     |     ");
            // variables
            Console.WriteLine($" {1}   |  {2}  |  {3}");
            Console.WriteLine("_____|_____|_____");

            //variables
            Console.WriteLine("     |     |     ");
            Console.WriteLine($" {4}   |  {5}  |  {6}");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");


            //input variables
            Console.WriteLine($" {7}   |  {8}  |  {9}");
            Console.WriteLine("     |     |     ");


        }
        //creating a method to decide X and O for each players
        public static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';

            if(player == 1)
            {
                playerSign = 'X';
            }

            else if (player == 2)
            {
                playerSign = 'O';
            }


            switch (input)
            {
                //player 2
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[2, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;
            }
            
            
        }
    }
}
