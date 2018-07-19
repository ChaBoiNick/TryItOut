using System;
using System.Collections.Generic;
using System.Text;

namespace TryItOut
{
    class Game
    {
        public static void StartGame()
        {

            Console.WriteLine("Welcome to America");

        }

        public static void CharacterName()
        {
            Console.WriteLine("Please enter your name");
            var CharacterName = Console.ReadLine();
            Console.WriteLine($"\nHi {CharacterName}, America is a land of mystical creatures and hella fatties. \nIt's dangerous. \nIt's unhealthy.\nAll you can do is just...\nTry it out. ");
        }
       
    }
}
