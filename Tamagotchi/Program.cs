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
            Console.Clear();

            bool alive = player1.GetAlive();

            while(alive == true){
                Console.WriteLine(player1.name);
                player1.PrintStats();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("What do you wish to do? (Type number)\n");
                Console.WriteLine("1. Teach your tamagotchi");
                Console.WriteLine("2. Greet your tamagotchi");
                Console.WriteLine("3. Feed your tamagotchi");
                Console.WriteLine("4. Do nothing");

                string answer = Console.ReadLine();

                if(answer == "1"){
                    Console.WriteLine("What word do you wish to teach " + player1.name + "?");

                    string wordTeach = Console.ReadLine();

                    player1.Teach(wordTeach);
                    player1.Tick();

                    Console.Clear();
                }

                else if(answer == "2"){
                    Console.WriteLine("Your tamagotchi looks for a word to respond with...");
                    player1.Hi();

                    player1.Tick();

                    Console.ReadLine();
                    Console.Clear();
                }

                else if(answer == "3"){
                    Console.WriteLine("You give " + player1.name + " some food.");
                    player1.Feed();

                    player1.Tick();

                    Console.ReadLine();
                    Console.Clear();
                }

                else if(answer == "4"){
                    Console.WriteLine("You stare at " + player1.name + ", but you do nothing...");

                    player1.Tick();

                    Console.ReadLine();
                    Console.Clear();
                }

                else{
                    Console.WriteLine("Please select a number between 1-4.");
                    Console.ReadLine();
                    Console.Clear();
                }

                    alive = player1.GetAlive();

            }

            if(alive == false){
                Console.WriteLine(player1.name + " has died.");
                Console.WriteLine("RIP");

                Console.ReadLine();
            }
            
        }
    }
}
