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
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("What do you wish to do? (Type number)\n");
                Console.WriteLine("1. Teach your tamagotchi");
                Console.WriteLine("2. Greet your tamagotchi");
                Console.WriteLine("3. Feed your tamagotchi");
                Console.WriteLine("4. Do nothing");

                string answer = Console.ReadLine();

                if(answer == "1"){
                    
                }

                else if(answer == "2"){

                }

                else if(answer == "3"){

                }

                else if(answer == "4"){

                }

                else{

                }
                
            }
            
        }
    }
}
