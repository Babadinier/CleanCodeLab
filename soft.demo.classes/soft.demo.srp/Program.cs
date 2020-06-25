using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace soft.demo.srp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ignacio = new Person(Guid.NewGuid(), "Ignacio", "0606060606");

            var baba = new Person(Guid.NewGuid(), "Baba", "0607070707");

            ignacio.AddContact(baba);

            ignacio.SaveContacts(@"C:\temp\srp", "contact.txt");
        }

        public class Person
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public List<Person> Contacts { get; set; }

            public Person(Guid id, string name, string phoneNumber)
            {
                Id = id;
                Name = name;
                PhoneNumber = phoneNumber;
                Contacts = new List<Person>();
            }

            public void AddContact(Person person)
            {
                Contacts.Add(person);
            }

            public void SaveContacts(string directoryPath, string fileName)
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                var sb = new StringBuilder();
                foreach(var contact in Contacts)
                {
                    sb.AppendLine(contact.ToString());
                }
                File.WriteAllText(Path.Combine(directoryPath, fileName), sb.ToString());
                
                System.Console.WriteLine("Contacts saved");
            }

            public override string ToString() {
                return $"Name: {Name}, PhoneNumber: {PhoneNumber}";
            }
        }
    }
}
