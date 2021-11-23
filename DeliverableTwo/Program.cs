using System;

namespace DeliverableTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What would you like to say?");
                string input = Console.ReadLine();
                string inputlower = input.ToLower();

                {
                    if (inputlower == "hello")
                    {
                        Console.WriteLine("Hi, good to see you!");
                    }
                }
                {
                    if (inputlower == "sup")
                    {
                        Console.WriteLine("I am good");
                    }
                }
                {
                    if (inputlower == "hello there")
                    {
                        Console.WriteLine("General Kenobi");
                    }
                }
                {
                    if (inputlower == "bye")
                    {
                        Console.WriteLine("Good Bye!");
                        break;
                    }
                }

            }

        }
    }
}

