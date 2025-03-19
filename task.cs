using System;
using System.Linq;

class FizzBuzzDetector
{
    public (string outputString, int count) GetOverlappings(string inputString)
    {
        // Input checking
        if (string.IsNullOrWhiteSpace(inputString) || inputString.Length < 7 || inputString.Length > 100)
        {
            throw new ArgumentException("Input string must be between 7 and 100 characters.");
        }

        // Split words by spaces
        string[] words = inputString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] result = new string[words.Length];

        int count = 0;
        int replacementCount = 0;

        for (int i = 0; i < words.Length; i++)
        {
            count++;

            bool isDivisibleBy3 = count % 3 == 0;
            bool isDivisibleBy5 = count % 5 == 0;

            if (isDivisibleBy3 && isDivisibleBy5)
            {
                result[i] = "FizzBuzz";
                replacementCount++;
            }
            else if (isDivisibleBy3)
            {
                result[i] = "Fizz";
                replacementCount++;
            }
            else if (isDivisibleBy5)
            {
                result[i] = "Buzz";
                replacementCount++;
            }
            else
            {
                result[i] = words[i];
            }
        }

        return (string.Join(" ", result), replacementCount);
    }
}

class Program
{
    static void Main()
    {
        FizzBuzzDetector detector = new FizzBuzzDetector();
        string input = "Mary had a little lamb Little lamb, little lamb Mary had a little lamb It's fleece was white as snow";

        var result = detector.GetOverlappings(input);

        Console.WriteLine("Output string:");
        Console.WriteLine(result.outputString);
        Console.WriteLine("\nCount: " + result.count);
    }
}
