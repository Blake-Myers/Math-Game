using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"hello {name.ToUpper()}, Its {date.DayOfWeek}. This is your math game. Thats great that your working on improving yourself\n");
            Console.WriteLine("Press any key to show the menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            var isGameOn = true;
            do
            {
                Console.Clear();
                Console.WriteLine($@"what game would you like to play today? Choose from the options below:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplicaiton
D - Division
Q - Quit the program");
                Console.WriteLine("---------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("addition game");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("subtraction game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("multiplication game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("division game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
            } while (isGameOn);
        }
    }
}
