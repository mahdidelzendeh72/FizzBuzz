using static System.Console;
namespace FizzBuzz.ConsoleApp
{
    internal static class ConsoleWrapper
    {
        public static int GetIntegerNumber(string text, string errorText)
        {
            while (true)
            {
                WriteLine(text);
                string input = ReadLine();
                if (int.TryParse(input, out int number))
                    return number;
                WriteLine(errorText);
            }
        }

        internal static void Write(string text)
        {
            WriteLine(text);
        }
    }
}
