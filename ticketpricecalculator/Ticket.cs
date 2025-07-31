using System;
using System.Globalization;

namespace TicketPriceCalculator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Ticket Price Calculator ===");
            int age = ReadNonNegativeInt("Enter your age: ");

            decimal price = (age <= 12 || age >= 65) ? 7m : 10m;

           
            Console.WriteLine($"Ticket price: GHC {price.ToString("0.00", CultureInfo.InvariantCulture)}");
        }

        private static int ReadNonNegativeInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int value) && value >= 0)
                    return value;

                Console.WriteLine("Invalid input. Please enter a non-negative whole number.");
            }
        }
    }
}
