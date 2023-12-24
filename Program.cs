// Creating a simple Text based game by Using OOP concepts in C#.

using System;
using OOPAdventure;

namespace TextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Text class with method LoadLanguage and passing English Language Class
            Text.LoadLanguage(new English());

            // Asking Player Name by accessing The Protected field from Text class method Language.
            Console.WriteLine(Text.Language.ChooseYourName);
            var playerName = Console.ReadLine();

            // Checking if the player name is empty
            if(playerName == string.Empty){
                playerName = Text.Language.DefaultName;
            }
            var player = new Player(playerName);
            Console.WriteLine(Text.Language.Welcome, player.CName);
            Console.ReadKey();
                        
        }
    }
}