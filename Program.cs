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
            if(playerName == string.Empty){
                playerName = "No Name";
            }
            Console.WriteLine($"Welcome, {playerName} to OOP Adventure.");
            Console.ReadKey(); 
                        
        }
    }
}