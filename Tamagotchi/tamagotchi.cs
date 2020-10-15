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

        public void Feed()
        {
            hunger = hunger - 2;

            if (hunger < 0)
            {
                hunger = 0;
            }
        }

        public void Hi()
        {

            if (words.Count == 0)
            {
                Console.WriteLine("Your tamagotchi doesn't know any words.");
            }
            else
            {
                int wordNumber = generator.Next(words.Count);
                Console.WriteLine(name + " says:");
                Console.WriteLine(words[wordNumber]);
                ReduceBoredom();
            }
        }

        public void Teach(string word)
        {
            words.Add(word);
            ReduceBoredom();
        }

        public void Tick()
        {
            boredom++;
            hunger++;

            if (hunger >= 10)
            {
                isAlive = false;
            }

            if (boredom >= 10)
            {
                isAlive = false;
            }
        }

        public void PrintStats()
        {
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Boredom: " + boredom);
            Console.WriteLine("Alive: " + GetAlive());
        }

        public bool GetAlive()
        {
            if (isAlive == false)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        private void ReduceBoredom()
        {
            boredom = boredom - 2;

            if (boredom < 0)
            {
                boredom = 0;
            }
        }

    }
}
