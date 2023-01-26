using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.ConsoleApp
{
    public static class FizzBuzzAlgorithm
    {
        public static string Count(int fizz, int buzz, int number)
        {
            IEnumerable<string> numbers = Enumerable.Range(1, number)
                                                    .Select(x => GetString(fizz, buzz, x));
            return String.Join(',', numbers);
        }

        private static string GetString(int fizz, int buzz, int x)
        {
            return x switch
            {
                int when (CheckedIsFizzOrbuzz(fizz, x) && CheckedIsFizzOrbuzz(buzz, x)) => "FizzBuzz",
                int when CheckedIsFizzOrbuzz(fizz, x) => "Fizz",
                int when CheckedIsFizzOrbuzz(buzz, x) => "Buzz",
                _ => x.ToString()

            };
        }

        private static bool CheckedIsFizzOrbuzz(int fizzORBuzz, int number)
        {
            return number % fizzORBuzz == 0;
        }
    }
}
