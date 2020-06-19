using System;

namespace soft.demo.naming
{
    class Program
    {
        static void Main(string[] args)
        {
            string fn = "Toto";
            string ln = "BLANC";

            var usrArray =  new UserInfo[1];
            usrArray[0] = new UserInfo(fn, ln);

            for(int i = 0; i < usrArray.Length; i++)
            {
                Console.WriteLine("Hello " + usrArray[i].LastName + " " + usrArray[i].FistName);
            }
        }

        public class UserInfo
        {
            public string FistName { get; set; }
            public string LastName { get; set; }

            public UserInfo(string firstName, string lastName)
            {
                FistName = firstName;
                LastName = lastName;
            }
        }
    }
}
