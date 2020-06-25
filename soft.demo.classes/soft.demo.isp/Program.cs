using System;

namespace soft.demo.isp
{
    class Program
    {
        static void Main(string[] args)
        {
            var lion = new Lion();
            lion.EatMeat();

            var cow = new Cow();
            cow.EatSalad();
        }

        public class Lion : IAnimal
        {
            public void EatMeat()
            {
                System.Console.WriteLine("Antilopes are tasty");
            }

            public void EatSalad()
            {
                throw new Exception("Salad is for cows");
            }
        }

        public class Cow : IAnimal
        {
            public void EatMeat()
            {
                throw new Exception("Meat is disgusting !!");
            }

            public void EatSalad()
            {
                System.Console.WriteLine("Salad are tasty");
            }
        }

        public interface IAnimal
        {
            void EatMeat();
            void EatSalad();
        }
    }
}
