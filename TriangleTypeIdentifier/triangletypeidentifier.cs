using System;

namespace TriangleTypeIdentifier
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Triangle Type Identifier ===");
            double a = ReadPositiveDouble("Enter side a: ");
            double b = ReadPositiveDouble("Enter side b: ");
            double c = ReadPositiveDouble("Enter side c: ");

            if (!IsValidTriangle(a, b, c))
            {
                Console.WriteLine("Not a valid triangle (violates triangle inequality).");
                return;
            }

            string type = (AreEqual(a, b) && AreEqual(b, c)) ? "Equilateral"
                        : (AreEqual(a, b) || AreEqual(b, c) || AreEqual(a, c)) ? "Isosceles"
                        : "Scalene";

            Console.WriteLine($"Triangle type: {type}");
        }

        private static bool IsValidTriangle(double x, double y, double z)
            => x + y > z && x + z > y && y + z > x;

        private static bool AreEqual(double x, double y, double eps = 1e-9)
            => Math.Abs(x - y) < eps;

        private static double ReadPositiveDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (double.TryParse(input, out double value) && value > 0)
                    return value;

                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }
    }
}
