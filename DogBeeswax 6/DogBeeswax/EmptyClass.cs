using System;
namespace DogBeeswax
{
    public class Dog
    {
        public enum DogTypes
        {
            Hound,
            Terrer,
            Toy,
            Non_sporting_dog,
            Sporting_dog,
            Hearding_dog,
            Working_dog,
            Mutt
        }

        public string Name { get; set; }
        public Person Owner { get; set; }
        public int Age { get; set; }
        public DogTypes Dogtype { get; set; }


        public int mood = 0;
        public int energy = 0;
        public int hunger = 10;
        public Dog(string name, Person owner, int age, DogTypes dogTypes)
        {
            Name = name;
            Owner = owner;
            Age = age;
            Dogtype = dogTypes;

        }

        public Dog(int age, DogTypes dogtype)
        {


            Age = age;
            Dogtype = dogtype;
        }
        public Dog()
        {


        }
        public static Dog Newdog(string name, string owner, int age, int ownerAge, bool stray, DogTypes dogtype)
        {
            Dog dog;

            if (!stray)
            {
                Person person = new Person(owner, ownerAge);
                dog = new Dog(name, person, age, dogtype);
            }
            else
            {

                dog = new Dog();
            }



            return dog;
        }






        public static Dog Newdog(string name, Person owner, int age, bool stray, DogTypes dogtype)
        {
            Dog dog;

            if (!stray)
            {

                dog = new Dog(name, owner, age, dogtype);
            }
            else
            {

                dog = new Dog();
            }



            return dog;
        }
        
        public static Dog SetDefautDog()
        {
            Dog dog = new Dog();
            return dog;
        }

        public static Dog CopyDog(Dog dog)
        {
            Dog dog1 = new Dog(dog.Name, dog.Owner, dog.Age, dog.Dogtype);
            return dog1;
        }
        public static void SwapDog(Dog dog, Dog dog1)
        {
            dog.Owner = dog1.Owner;
            dog1.Owner = dog.Owner;
        }
        public void Obay()
        {
            Console.WriteLine("Good boy!");
        }
        public void Bark()
        {
            Console.WriteLine("woof");
        }
        public void Eat()
        {
            energy++;
            hunger--;
            mood++;
        }
        public void Play()
        {
            energy--;
            mood++;
            if (energy <= 0)
            {
                Eat();
            }

        }
        public void Sleep()
        {
            energy++;
            hunger++;
        }

    }
    public  class IndependentDog : Dog
    {
        public IndependentDog(string name, int age, DogTypes dogtype)
        {

            Name = name;
            Age = age;
            Dogtype = dogtype;

        }
        public IndependentDog()
        {

            
        }
        public static IndependentDog Newdog(string name, int age, bool stray, DogTypes dogtype)
        {
            IndependentDog dog;

            if (!stray)
            {

                dog = new IndependentDog(name, age, dogtype);
            }
            else
            {

                dog = new IndependentDog();
            }



            return dog;
        }

    }
}
//This code is part of DogBeeswax verson 5.0.
//DogBeeswax is a fun C#  framework that allows the user to play with it's src code and understand OOP

// cool!
