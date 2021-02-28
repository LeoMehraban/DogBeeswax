using System;
namespace DogBeeswax
{
    public class Person

    {
        public static Person SetDefautPerson()
        {
            Person person = new Person();
            return person;
        }

        public string Name { get; set; }

        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;

            Age = age;



        }
        public Person(string name)
        {
            Name = name;





        }
        public Person(int age)
        {


            Age = age;



        }
        public Person()
        {




        }
        public static Person CopyPerson(Person person)
        {
            Person person1 = new Person(person.Name, person.Age);
            return person1;
        }
        public static Person NewPerson(string name, int age)
        {
            Person person = new Person(name, age);
            return person;
        }
        public void Speek(string word)
        {
            Console.WriteLine(word);
        }

    }
}
//This code is part of DogBeeswax verson 4.5.
//DogBeeswax is a fun C#  framework that allows the user to play with it's src code and understand OOP

