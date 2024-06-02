using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their age
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            // Convert the input string to an integer
            if (int.TryParse(input, out int age))
            {
                // Check if the age is within the valid range
                if (age >= 0)
                {
                    // Calculate the ticket price based on age
                    decimal ticketPrice;
                    if (age <= 12 || age >= 65)
                    {
                        ticketPrice = 7; // Discounted price for seniors and children
                    }
                    else
                    {
                        ticketPrice = 10; // Regular price for adults
                    }

                    // Display the ticket price
                    Console.WriteLine($"The ticket price for your age ({age}) is GHC{ticketPrice}");
                }
                else
                {
                    Console.WriteLine("Invalid age. Please enter a valid age.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}
