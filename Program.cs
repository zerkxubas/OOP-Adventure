// Creating a simple Text based game by Using OOP concepts in C#.

using System;
using OOPAdventure;

namespace TextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using English Language Class
            var language = new English();
            
            // Asking Player Name by accessing The Protected field.
            Console.WriteLine(language.ChooseYourName);
            var playerName = Console.ReadLine();

            // Checking if the player name is empty
            if(playerName == string.Empty){
                playerName = "No Name";
            }
            var player = new Player(playerName);
            Console.WriteLine($"Welcome, {player.CName} to OOP Adventure.");
            Console.ReadKey();
                        
        }
    }
}