using System;
using System.Linq;

namespace soft.demo.lsp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

            SumCalculator sum = new SumCalculator(numbers);
            System.Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");

            System.Console.WriteLine();

            EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
            System.Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");

            // What is the result ? 
            SumCalculator evenSum2 = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum2.Calculate()}");
        }
    }

    public class SumCalculator
    {
        protected readonly int[] _numbers;

        public SumCalculator(int[] numbers)
        {
            _numbers = numbers;
        }

        public int Calculate() => _numbers.Sum();
    }

    public class EvenNumbersSumCalculator : SumCalculator
    {
        public EvenNumbersSumCalculator(int[] numbers)
            : base(numbers)
        {
        }

        public new int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
    }
}
