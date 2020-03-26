using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program1to10
    {
        /// <summary>
        /// Returns a sum of all Multiples of 3 and 5
        /// </summary>
        /// <param name="maxlimit">Upper Limit</param>
        /// <returns>Summation</returns>
        public static int sumOfMultiplesof3and5(int maxlimit)
        {
            int sum = 0;
            for (
                int i = maxlimit - 1; i >= 3; i--)
            {
                sum += (i % 3).Equals(0) || (i % 5).Equals(0) ? i : 0;
            }
            return sum;
        }

        /// <summary>
        /// Finds the sum of even Fibonacci number up to 4 Million
        /// </summary>
        /// <returns></returns>
        public static long sumofEvenFib()
        {
            int maxLimit = (int)Math.Round(4 * Math.Pow(10, 6));

            //Get a the list of Fibonacci numbers.
            List<long> fibonacciSeries = Helper.FibonacciSeries(maxLimit);

            //Get the sum.
            return Helper.sumOfEvenNumbersInList(fibonacciSeries);
        }

        public static long largestPrimeFactor(long number)
        {
            //int sqrt = (int)Math.Sqrt(number);
            List<long> factors = new List<long> { };
            for(long factor = 1; factor * factor <= number; factor++)
            {
                if (number % factor == 0)
                {
                    if (Helper.isPrime(factor)) factors.Add(factor);
                    if (Helper.isPrime(number / factor)) factors.Add(number / factor);
                }
            }
            return factors.Max();
        }

        public static long LargestSquareDifference(int maxLimit)
        {
            int squareofsum = (int)Math.Pow((maxLimit * (maxLimit + 1)) / 2, 2);
            int sumofsquares = (maxLimit * (maxLimit + 1) * ((2 * maxLimit) + 1)) / 6;
            return squareofsum - sumofsquares;
        }

        public static long SmallestMultiple(int maxLimit)
        {
            long number = 3;
            int divisor;
            bool sDivisible = true;
            while (sDivisible)
            {
                for (divisor = 1; divisor <= maxLimit; divisor++)
                {
                    sDivisible = number % divisor == 0;
                    if (!sDivisible)
                    {
                        break;
                    }
                }
                if (sDivisible)
                {
                    return number;
                }
                else
                {
                    sDivisible = true;
                }
                number++;
            }
            return number;
        }

        public static long NthPrimeNumber(int position)
        {
            int count = 1;
            long number;
            for (number = 3; count < position ;number = number + 2 )
            {
                if (Helper.isPrime(number))
                {
                    count++;
                    Console.WriteLine("Number : " + number + "  Counter: " + count);
                }
            }
            return number - 2;
        }

        public static long LargestProductInSeries(string series, int noOfConsecutiveNumbers)
        {
            int[] numbersInSeries = series.ToCharArray().Select(number => number - '0').ToArray();
            List<int> consecutiveNumbers = new List<int> { };
            long product = 0;
            long greatestProduct = 0;
            for (int i = 0; i < numbersInSeries.Length - noOfConsecutiveNumbers; i++)
            {
                for (int j = i; j < i + noOfConsecutiveNumbers; j++)
                {
                    consecutiveNumbers.Add(numbersInSeries[j]);
                }
                product= Helper.productOfNumbersInSeries(ref consecutiveNumbers);
                if (product > greatestProduct) greatestProduct = product;
            }
            return greatestProduct;
        }

        public static string SpecialPythagoreanTripletProduct(int sum)
        {
            for (int i = 2; i <= sum; i++)
            {
                for(int j = i; j <= sum; j++)
                {
                    for (int k = j; k <= sum; k++)
                    {
                        if(i+j+k == sum)
                        {
                            if (Helper.isPythagoreanTirplet(i,j,k))
                            {
                                return (i * j * k).ToString();
                            }
                        }
                    }
                }
           }
            return "Not found";
        }

        public static long sumationOfPrimes(long MaxLimit)
        {
            long sum = 0;
            while (MaxLimit > 2)
            {
                if (MaxLimit % 2 == 0)  MaxLimit --;

                if (Helper.isPrime(MaxLimit))
                {
                    sum += MaxLimit;
                }
                MaxLimit = MaxLimit - 2;
            }
            return sum + 2;
        }

    }
}
