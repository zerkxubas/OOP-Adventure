// Creating a simple Text based game by Using OOP concepts in C#.

using System;
using OOPAdventure;

namespace TextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking Player Name
            Console.WriteLine("Hello Player, What Is Your Name ? ");
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