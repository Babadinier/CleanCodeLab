using System;

namespace soft.demo.comment
{
    // Copyright (C) 2020 by Nano Corporation, Inc. All rights reserved.

    /* Changes (from 02/01/2020)
        ----------------------------
        02/01/2020 - Create project 
        03/01/2020 - Add a toString() method to animal (IR)
        07/01/2020 - Add code to set property old of animal (GB)
    */

    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animal(1, "Simba", Gender.M, 12, AnimalType.LION);

            // if animal is male and age > 10 and animalType is Lion
            if (animal.Gender == Gender.M && animal.Age > 10 && animal.Type == AnimalType.LION)
            {
                animal.IsOld();
            }

            System.Console.WriteLine(animal.ToString());
        }

        public class Animal
        {
            // todo: change Id to Guid
            public int Id { get; }
            public string Name { get; }
            public Gender Gender { get; }
            public int Age { get; }
            public bool Old { get; private set; }
            public AnimalType Type { get; }
            // public List<Animal> Children { get; }

            public Animal(int id, string name, Gender gender, int age, AnimalType type)
            {
                Id = id;
                Name = name;
                Gender = gender;
                Age = age;
                Type = type;
                // Children = new List<Animal>();
            }

            public void IsOld()
            {
                Old = true;
            }

            // Method that display the properties of animal
            public override string ToString()
            {
                return $"Name: {Name}, Gender: {Gender}, Age: {Age}, Type: {Type}";
            }

            // public void AddChildren(Animal animal)
            // {
            //     var childrenExists = Children.SingleOrDefault(child => child.Name == animal.Name);

            //     if (!childrenExists)
            //     {
            //         Children.Add(animal);
            //     }
            // }
        }

        public enum Gender
        {
            M, // Male
            F // Female
        }

        public enum AnimalType
        {
            LION,
            COW
        }
    }
}
