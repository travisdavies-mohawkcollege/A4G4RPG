using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4_a4_RPGBattle
{
    class Player
    {
Console.WriteLine("Choose an action:");
Console.WriteLine("1. Attack");
Console.WriteLine("2. Switch Pokemon");
Console.WriteLine("3. Use Item");
Console.WriteLine("4. Run");

string userInput = Console.ReadLine();

if (userInput == "1")
{
    // Player chose to attack
    Console.WriteLine("You chose to attack!");
}
else if (userInput == "2")
{
    // Player chose to switch Pokemon
    Console.WriteLine("You chose to switch Pokemon!");
}
else if (userInput == "3")
{
    // Player chose to use an item
    Console.WriteLine("You chose to use an item!");
}
else if (userInput == "4")
{
    // Player chose to run
    Console.WriteLine("You chose to run!");
}
else
{
    // Invalid input
    Console.WriteLine("Invalid input.");
}

public class PokemonBattle
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Choose an action:");
        Console.WriteLine("1. Attack");
        Console.WriteLine("2. Switch Pokemon");
        Console.WriteLine("3. Use Item");
        Console.WriteLine("4. Run");

        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                Console.WriteLine("You chose to attack!");
                // Implement attack logic here
                break;
            case "2":
                Console.WriteLine("You chose to switch Pokemon!");
                // Implement switch logic here
                break;
            case "3":
                Console.WriteLine("You chose to use an item!");
                // Implement item logic here
                break;
            case "4":
                Console.WriteLine("You chose to run!");
                // Implement run logic here
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }
    }
}
    }

}
