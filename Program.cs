using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------- PART 1 ----------
            // Ask the user for a number to multiply by 50
            Console.WriteLine("Enter a number to multiply by 50:");

            // Read user input as a string and convert it to a long
            // long is used so we can handle numbers larger than 10,000,000
            long multiplyInput = Convert.ToInt64(Console.ReadLine());

            // Multiply the input by 50
            long multiplyResult = multiplyInput * 50;

            // Print the result to the console
            Console.WriteLine("Result: " + multiplyResult);

            // ---------- PART 2 ----------
            // Ask the user for a number to add 25 to
            Console.WriteLine("\nEnter a number to add 25:");

            // Convert user input to an integer
            int addInput = Convert.ToInt32(Console.ReadLine());

            // Add 25 to the input
            int addResult = addInput + 25;

            // Print the result
            Console.WriteLine("Result: " + addResult);

            // ---------- PART 3 ----------
            // Ask the user for a number to divide by 12.5
            Console.WriteLine("\nEnter a number to divide by 12.5:");

            // Convert input to double to allow decimal division
            double divideInput = Convert.ToDouble(Console.ReadLine());

            // Divide the input by 12.5
            double divideResult = divideInput / 12.5;

            // Print the result
            Console.WriteLine("Result: " + divideResult);

            // ---------- PART 4 ----------
            // Ask the user for a number to check if it is greater than 50
            Console.WriteLine("\nEnter a number to check if it is greater than 50:");

            // Convert input to integer
            int compareInput = Convert.ToInt32(Console.ReadLine());

            // Check if the number is greater than 50
            bool isGreaterThan50 = compareInput > 50;

            // Print true or false
            Console.WriteLine("Is greater than 50? " + isGreaterThan50);

            // ---------- PART 5 ----------
            // Ask the user for a number to divide by 7 and get the remainder
            Console.WriteLine("\nEnter a number to divide by 7:");

            // Convert input to integer
            int remainderInput = Convert.ToInt32(Console.ReadLine());

            // Use the modulus (%) operator to get the remainder
            int remainderResult = remainderInput % 7;

            // Print the remainder
            Console.WriteLine("Remainder: " + remainderResult);

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
