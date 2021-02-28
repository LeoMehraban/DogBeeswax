using DogBeeswax;
using System;
namespace Dog1
{

    class MainClass
    {
        
        
        public static void Main(string[] args)
        {

            Dog dog = Dog.Newdog("joe", "emma", 5, 20,false,Dog.DogTypes.Non_sporting_dog);
            Dog dog1 = Dog.Newdog("phil", "elon", 2, 100,false, Dog.DogTypes.Sporting_dog);
            Dog.SwapDog(dog, dog1);
            if(dog.Owner.Name == "emma")
            {
                Console.WriteLine("fail");
            }
            else
            {
                Console.WriteLine("sussess");
            }
            Dog blankdog = Dog.SetDefautDog();
            Person blankperson = Person.SetDefautPerson();
        }
    }  
}
//this is whare you run DogBeeswax...
//have fun!
