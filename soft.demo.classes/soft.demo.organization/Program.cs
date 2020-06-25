using System;

namespace soft.demo.classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var adrian = new Person(Guid.NewGuid(), "Adrian", 200);
            var ageIsAuthorized = adrian.CheckAgeIsAuthorized();

            if (!ageIsAuthorized){
                throw new Exception($"Value of age is not authorized: {adrian.Age}");
            }
        }

        public class Person {
            public Person(Guid id, string name, int age)
            {
                Id = id;
                Name = name;
                Age = age;
            }

            public Guid Id { get; set; }
            public string Name { get; set; }

            public bool CheckAgeIsAuthorized()
            {
                return Age > MinAge && Age < MaxAge;
            }

            public int Age { get; set; }

            public string Address1 { get; set; }
            public string ZipCode { get; set; }
            public string City { get; set; }
            public string Country { get; set; }

            public void SetAddress(string address1, string zipCode, string city, string country) {
                Address1 = address1;
                ZipCode = zipCode;
                City = city;
                Country = country;
            }

            private const int MaxAge = 150;
            private const int MinAge = 0;
        }
    }
}
