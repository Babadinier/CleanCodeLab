namespace soft.demo.testing.console.services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string GetValue(int number)
        {
            var result = string.Empty;
            if (number % 3 == 0)
            {
                result += "Fizz";
            }
            if (number % 5 == 0)
            {
                result += "Buzz";
            }

            return result == string.Empty ? number.ToString() : result;
        }
    }
}
