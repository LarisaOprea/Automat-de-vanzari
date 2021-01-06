using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_de_vanzari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("One coffee is 20 cents.");
            Console.WriteLine("The vending machine accepts 5, 10 and 25 cents.");
            int repeat, coins, sumcoins = 0;
            do
            {
                sumcoins = 0;
                Console.WriteLine("Insert your coins:");
                do
                {
                    coins = int.Parse(Console.ReadLine());
                    if (coins == 5)
                        sumcoins += coins;
                    else if (coins == 10)
                        sumcoins += coins;
                    else if (coins == 25)
                        sumcoins += coins;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Coin is not valid, please try again.");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"You have {sumcoins} in the machine.");

                } while (sumcoins < 20);
                Console.WriteLine();
                if (sumcoins == 20)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Here is your coffee.");
                    Console.WriteLine();
                }
                else
                {
                    int rest;
                    rest = sumcoins - 20;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Here is your coffee.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"You got {rest} cents back.");
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Would you like another coffee? (0=no/1=yes)");
                repeat = int.Parse(Console.ReadLine());
            } while (repeat == 1);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
    }
}
