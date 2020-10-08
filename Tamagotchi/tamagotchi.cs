using System;

namespace Tamagotchi
{
    public class tamagotchi
    {
        public string name = "";
        int hunger = 0;
        int boredom = 0;
        string[] words;
        bool isAlive = true;
        Random generator = new Random();

        public void Feed(){
            hunger--;

            if (hunger < 0){
                hunger = 0;
            }
        }

        public void Hi(){

        }

        public void Teach(string word){
            
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
            if (isAlive == true){
                return true;
            }

            else {
                return false;
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
