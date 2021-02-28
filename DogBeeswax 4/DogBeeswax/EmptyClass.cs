﻿using System;
namespace DogBeeswax
{
    public class Dog
    {

        public string Name { get; set; }
        public Person Owner { get; set; }
        public int Age { get; set; }
        public int mood = 0;
        public int energy = 0;
        public int hunger = 10;
        public Dog(string name, Person owner, int age)
        {
            Name = name;
            Owner = owner;
            Age = age;

        }
        public Dog(string name, int age)
        {

            Name = name;
            Age = age;
        }
        public Dog(int age)
        {

            
            Age = age;
        }
        public Dog()
        {

           
        }
        public static Dog Newdog(string name, string owner, int age, int ownerAge, bool stray)
        {
            Dog dog;

            if (!stray)
            {
                Person person = new Person(owner,ownerAge);
                dog = new Dog(name, person, age);
            }
            else
            {
                
                dog = new Dog();
            }



            return dog;
        }
        public  static Dog Newdog(string name, int age, bool stray)
        {
            Dog dog;

            if (!stray)
            {
                
                dog = new Dog(name,  age);
            }
            else
            {

                dog = new Dog();
            }



            return dog;
        }
        public static Dog Newdog(string name, Person owner, int age,  bool stray)
        {
            Dog dog;

            if (!stray)
            {
               
                dog = new Dog(name, owner, age);
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
            Dog dog1 = new Dog(dog.Name, dog.Owner, dog.Age);
            return dog1;
        }
        public static void SwapDog(Dog dog,Dog dog1)
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
        public  void Sleep()
        {
            energy++;
            hunger++;
        }

    }
    
}
//This code is part of DogBeeswax verson 4.5.
//DogBeeswax is a fun C#  framework that allows the user to play with it's src code and understand OOP

// cool!
