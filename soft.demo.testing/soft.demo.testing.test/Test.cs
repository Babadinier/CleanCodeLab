using Xunit;
using soft.demo.testing.app.services;

namespace soft.demo.testing
{
    public class Test
    {
        private readonly IFizzBuzzService fizzBuzzService;
        public Test()
        {
            fizzBuzzService = new FizzBuzzService();
        }

        [Fact]
        public void Return_Fizz()
        {
            var result = fizzBuzzService.GetValue(3);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Return_Buzz_And_FizzBuzz_When_Divisible_By_3_And_5()
        {
            var result = fizzBuzzService.GetValue(5);
            Assert.Equal("Buzz", result);

            var result2 = fizzBuzzService.GetValue(15);
            Assert.Equal("FizzBuzz", result2);
        }
    }
}