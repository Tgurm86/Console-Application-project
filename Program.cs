// Import the System namespace for basic input/output operations.
using System;

namespace PackageExpressShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message to the user.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the package weight.
            Console.Write("Please enter the package weight: ");
            // Validate the user's input and convert it to a double.
            if (!double.TryParse(Console.ReadLine(), out double weight))
            {
                Console.WriteLine("Invalid input for weight. Exiting program.");
                return; // End the program if the input is not a valid number.
            }

            // Check if the package weight is greater than the allowed maximum (50).
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End the program if the weight exceeds the limit.
            }

            // Prompt the user to enter the package width.
            Console.Write("Please enter the package width: ");
            if (!double.TryParse(Console.ReadLine(), out double width))
            {
                Console.WriteLine("Invalid input for width. Exiting program.");
                return;
            }

            // Prompt the user to enter the package height.
            Console.Write("Please enter the package height: ");
            if (!double.TryParse(Console.ReadLine(), out double height))
            {
                Console.WriteLine("Invalid input for height. Exiting program.");
                return;
            }

            // Prompt the user to enter the package length.
            Console.Write("Please enter the package length: ");
            if (!double.TryParse(Console.ReadLine(), out double length))
            {
                Console.WriteLine("Invalid input for length. Exiting program.");
                return;
            }

            // Calculate the total of the dimensions (width, height, and length).
            double totalDimensions = width + height + length;
            // Check if the total dimensions exceed the maximum allowed value (50).
            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End the program if the package dimensions exceed the limit.
            }

            // Calculate the package volume by multiplying width, height, and length.
            double volume = width * height * length;
            // Calculate the shipping quote by multiplying the volume by the weight, then dividing by 100.
            double shippingQuote = (volume * weight) / 100;

            // Display the shipping quote to the user formatted as a dollar amount with two decimal places.
            Console.WriteLine($"Your estimated total for shipping this package is: ${shippingQuote:F2}");
            // Thank the user for using the service.
            Console.WriteLine("Thank you!");
        }
    }
}
