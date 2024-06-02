using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the lengths of the three sides of the triangle
            Console.WriteLine("Enter the lengths of the three sides of the triangle:");

            Console.Write("Side 1: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Side 2: ");
            double side2 = double.Parse(Console.ReadLine());

            Console.Write("Side 3: ");
            double side3 = double.Parse(Console.ReadLine());

            // Check if the triangle is valid
            if (IsValidTriangle(side1, side2, side3))
            {
                // Determine the type of triangle
                string triangleType = IdentifyTriangleType(side1, side2, side3);

                // Display the type of triangle
                Console.WriteLine($"The triangle is {triangleType}.");
            }
            else
            {
                Console.WriteLine("Invalid triangle: the sum of the lengths of any two sides must be greater than the length of the remaining side.");
            }
        }

        // Method to check if the triangle is valid
        static bool IsValidTriangle(double side1, double side2, double side3)
        {
            return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
        }

        // Method to identify the type of triangle
        static string IdentifyTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}
