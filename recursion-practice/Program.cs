using System;

namespace recursion_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Sum of positive integers from 1 to 5: {SumIntegersFromOneToN(5)}");
            Console.WriteLine("Sum of the digits of the number 1999: " + SumDigits(1999));
            Console.WriteLine($"Is 17 a prime number? {IsPrime(17)}");
            Console.WriteLine($"If Spiderman has to swing through 5 buildings, " +
                $"the number of ways (different paths) he can do it is: {CalculatePossiblePaths(5)}");

        }

        // 1. Write a program in C# to calculate the sum of numbers from 1 to n
        // using recursion.
        static int SumIntegersFromOneToN(int n)
        {
            //base case:
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + SumIntegersFromOneToN(n - 1);
            }
        }

        // 2. Write a program in C# to find the sum of digits of a number using
        // recursion.
        /*
        123 -> 6 
        
        123 % 10 = 3
        12  % 10 = 2
        1   % 10 = 1
        total    = 6
         */
        static int SumDigits(int n)
        {
            //base case:
            if (n < 10)
            {
                return n;
            }
            else
            {
                return (n % 10) + SumDigits(n / 10);
            }
        }

        // 3. Write a program in C to check a number is a prime number or not
        // using recursion.
        static bool IsPrime(int n)
        {
            return IsPrime(n, 2);
        }
        static bool IsPrime(int n, int i)
        {
            // i is supposed to start as 2.
            if (n % i == 0)
            {
                return false;
            }
            else if ( i >= n / 2)
            {
                return true;
            }
            else
            {
                return IsPrime(n, i+1);
            }
        }

        // [spiderman buildings thing]
        static int CalculatePossiblePaths(int b)
        {
            //Console.WriteLine("Current Building = " + b);

            if (b >= 2)
            {
                return CalculatePossiblePaths(b - 1) + CalculatePossiblePaths(b - 2);
            }
            else if (b == 1)
            {
                return CalculatePossiblePaths(b - 1);
            }
            // There are no buildings left, a path has been completed.
            else
            {
                return 1;
            }
        }

    }
}
