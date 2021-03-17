using System;

namespace recursion_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Sum of positive integers from 1 to 5 (expected "
                              + $"value is 15): {SumIntegersFromOneToN(5)}");
            Console.WriteLine(SumDigits(1999));
            Console.WriteLine(IsPrime(113, 2));

            decimal a = 6/2;
            int b = 1;
            Console.WriteLine(a > b);
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
    }
}
