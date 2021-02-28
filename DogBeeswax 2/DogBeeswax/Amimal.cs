using System;
namespace DogBeeswax
{
    class Animal  // Base class (parent) 
    {
        public void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public string Sound { get; set; }
        public new void animalSound()
        {

            Console.WriteLine("The pig says: wee wee");
            Sound = "oynk";
        }
    }

    class Dog1 : Animal  // Derived class (child) 
    {
        public string Sound { get; set; }
        public new void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
            Sound = "woof";
        }
    }

    class Bird : Animal  // Derived class (child) 
    {
        public string Sound { get; set; }
        public new void animalSound()
        {
            Console.WriteLine("The bird says: tweet");
            Sound = "tweet";
        }
    }
}
