using System;

namespace GradeCalculator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Grade Calculator ===");
            int grade = ReadIntInRange("Enter a numerical grade (0–100): ", 0, 100);

            string letter = grade >= 90 ? "A" :
                            grade >= 80 ? "B" :
                            grade >= 70 ? "C" :
                            grade >= 60 ? "D" : "F";

            Console.WriteLine($"Letter grade: {letter}");
        }

        private static int ReadIntInRange(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int value) && value >= min && value <= max)
                    return value;

                Console.WriteLine($"Invalid input. Please enter an integer between {min} and {max}.");
            }
        }
    }
}
