using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class tamagotchi
    {
        public string name = "";
        int hunger = 0;
        int boredom = 0;
        List<string> words = new List<string>();
        bool isAlive = true;
        Random generator = new Random();

        public void Feed(){
            hunger--;

            if (hunger < 0){
                hunger = 0;
            }
        }

        public void Hi(){
            int lenght = words.Count;
            int wordNumber = generator.Next(lenght);

            Console.WriteLine(words[wordNumber]);
        }

        public void Teach(string word){
            words.Add(word);
            ReduceBoredom();
        }

        public void Tick(){
            boredom++;
            hunger++;
        }

        public void PrintStats(){
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Boredom: " + boredom);
            Console.WriteLine(GetAlive());
        }

        public bool GetAlive(){
            if (hunger >= 10){
                return false;
            }

            else if(boredom >= 10){
                return false;
            }

            else {
                return true;
            }
        }

        private void ReduceBoredom(){
            boredom--;

            if (boredom < 0){
                boredom = 0;
            }
        }

    }
}
