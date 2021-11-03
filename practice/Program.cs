using System;

namespace practice
{
    class Program
    {
        //global variables
        static string username;
        static string password;
        static void Main(string[] args)
        {
            //create a user login system
            Register();
            Login();
            Console.Read();

             static void Register()
            {
                Console.WriteLine("Please enter your user name");
                username = Console.ReadLine();
                Console.WriteLine("Please enter your password");
                password = Console.ReadLine();
                Console.WriteLine("Register completed");
            }
            //void doesn't have a return 
            //static needs to be call up on the same class and in the main
            static void Login()
            {
                //nested if else statement
                Console.WriteLine("Please enter your name");
                if(username == Console.ReadLine())
                {
                    Console.WriteLine("Please enter your password");
                    if (password == Console.ReadLine())
                    {
                        Console.WriteLine("Login Success");
                    }
                    else
                    {
                        Console.WriteLine("Please Register");
                    }
                }
                else
                {
                    Console.WriteLine("Please register before Login");
                }
            }

        }
    }

    }
