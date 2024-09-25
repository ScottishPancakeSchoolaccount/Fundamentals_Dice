using System;
using System.Diagnostics.CodeAnalysis;

namespace dice
{
    internal class Program
    {
        enum kindOfDie { Twenty, Six, Ten}
        static void Main(string[] args)
        {
            string what;
            Console.WriteLine("What die do you wanna roll?");
            Console.WriteLine("1 = ten");
            Console.WriteLine("2 = twenty");
            Console.WriteLine("3 = six");
            what = "nothing";

            Random rnd = new Random();
            int result;

            if (Console.ReadKey().Key == ConsoleKey.D1)
            {
                what = "Ten";
            }
            else if (Console.ReadKey().Key == ConsoleKey.D2)
            {
                what = "Twenty";
            }
            else if (Console.ReadKey().Key == ConsoleKey.D3)
            {
                what = "Six";
            }
            Console.WriteLine();

            switch (what)
            {
                case "Twenty":
                    result = rnd.Next(1, 21); 
                    Console.WriteLine($"the D20 result is {result}"); //change this to your dice
                    break;
                case "Six":
                    result = rnd.Next(1, 7); // for my D6 I have 1-7 this is not a mistake but I cant remember the reason why it had to be one higher. Change this to fit you dice.
                    Console.WriteLine($"the D6 result is {result}"); //change this to your dice
                    break;
                case "Ten":
                    result = rnd.Next(1, 11); 
                    Console.WriteLine($"the D10 result is {result}"); //change this to your dice
                    break;
                default: break;
            }
        }
    }
}