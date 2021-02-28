using DogBeeswax;
using System;
namespace Dog1
{

    class MainClass
        {
        
        
        public static void Main(string[] args)
            {
           
            var joey =  Dog.Newdog("Joey", "Leo", 4, 10, false);
            var bill = Dog.Newdog("Bill", "Fread", 4, 10, false);
            var frank = Dog.Newdog("frank", "Dudet", 4, 100, false);
            joey.Play();
            Dog.SwapDog(bill, frank);
            if(frank.Owner.Name == "Fread")
            {
                Console.WriteLine("⚔️");
            }
            else
            {
                Console.WriteLine("😢");
            }

        }
        }
    }

