namespace FizzBuzz.ConsoleApp
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            int fizzNumber = ConsoleWrapper.GetIntegerNumber("please enter a number as fizz", "you enter invalid number");
            int buzzNumber = ConsoleWrapper.GetIntegerNumber("please enter a number as buzz", "you enter invalid number");
            int number = ConsoleWrapper.GetIntegerNumber("please enter a number for count", "you enter invalid number");

            ConsoleWrapper.Write(FizzBuzzAlgorithm.Count(fizzNumber, buzzNumber, number));
        }
    }
}
