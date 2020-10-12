using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            tamagotchi player1 = new tamagotchi();

            Console.WriteLine("Please enter a name for your tamagotchi:");
            player1.name = Console.ReadLine();
        }
    }
}
