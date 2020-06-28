using System;
using soft.demo.testing.console.services;
using Microsoft.Extensions.DependencyInjection;

namespace soft.demo.testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddTransient<IFizzBuzzService, FizzBuzzService>()
                .BuildServiceProvider();

            var fizzBuzzService = serviceProvider.GetService<IFizzBuzzService>();

            for (int index = 0; index < 100; index++)
            {
                System.Console.WriteLine(fizzBuzzService.GetValue(index));
            }
        }
    }
}
