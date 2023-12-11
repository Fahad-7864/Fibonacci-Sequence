using System;
using System.Numerics; 


class Fibonacci
{
    static void Main(string[] args)
    {
        // Set default Fibonacci sequence number to 10
        int n = 10;

        // Prompt the user for input
        Console.WriteLine("Enter a number (or press Enter for the 100th Fibonacci number):");
        string input = Console.ReadLine();

        // Check if input is not empty and is a valid integer
        if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int userInput))
        {
            n = userInput;
        }

        // Calculate the nth Fibonacci number
        BigInteger fibonacciNumber = CalculateFibonacci(n);

        Console.WriteLine($"The {n}th Fibonacci number is: {fibonacciNumber}");
    }

    // Method to calculate the nth Fibonacci number
    static BigInteger CalculateFibonacci(int n)
    {
        BigInteger a = 0; 
        BigInteger b = 1;
        BigInteger c; 

        // Special case for 0th Fibonacci number
        if (n == 0) return a;

        // Iterate from 2 to n (since first two Fibonacci numbers are already set)
        for (int i = 2; i <= n; i++)
        {
            // Calculate the next Fibonacci number
            c = a + b;

            // Update values of a and b for the next iteration
            a = b;
            b = c;
        }

        // After the loop, b contains the nth Fibonacci number
        return b;
    }
}
