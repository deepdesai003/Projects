using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Helper
    {
        public int sumOfEvenNumbers(int MaxLimit)
        {
            int sum = 0;
            for(int i = 0; i <= MaxLimit; i++)
            {
                sum += i % 2 == 0 ? i : 0;
            }

            return sum;
        }
        public static long sumOfEvenNumbersInList(List<long> numbers)
        {
            return numbers.Where(number => (number % 2 == 0)).Sum();
        }

        /// <summary>
        /// Find all Fibonacci numbers Starts with 1 upto the number inputted.
        /// </summary>
        /// <param name="maxLimit">The number where the series ends</param>
        /// <returns>A list of sorted Fibonacci Numbers</returns>
        public static List<long> FibonacciSeries(int maxLimit)
        {
            List<long> fibonacciSeries = new List<long> { };

            //To return the first Fibonacci number

            fibonacciSeries.Add(1);
            fibonacciSeries.Add(2);

            if (maxLimit == 1)
            {
                return fibonacciSeries;
            }

            long lastfib = fibonacciSeries.LastOrDefault();
            while (lastfib <= maxLimit)
            {
                fibonacciSeries.Add(lastfib + fibonacciSeries.ElementAt(fibonacciSeries.LastIndexOf(lastfib) - 1));
                lastfib = fibonacciSeries.LastOrDefault();
            }

            return fibonacciSeries;
        }

        /// <summary>
        /// Check weather a given number is prime.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Boolean</returns>
        public static bool isPrime(long number)
        {
            try
            {

                if (number == 2 || number == 3) return true;
                if (number == 0 || number == 1) return false;

                if (number % 2 == 0 || number % 3 == 0) return false;

                for (long i = 5; i <= number; i = i + 6)
                {
                    if ((number % i == 0) || (number % (i + 2)) == 0) return false;
                }

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at siPrime():" + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read the string from file
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public static string readFromFile(string FileName)
        {
            string text = System.IO.File.ReadAllText(FileName);
            Console.WriteLine(text);
            return text;
        }

        public static string[] readLinesFromFile(string FileName)
        {
            string[] text = System.IO.File.ReadAllLines(FileName);
            Console.WriteLine(text);
            return text;
        }

        public static long productOfNumbersInSeries(ref List<int> series)
        {
            long product = 1;
            series.ForEach(number => product = product * number);
            series.Clear();
            return product;
        }

        public static bool isPythagoreanTirplet(int a, int b, int c)
        {
            return (a<b) && (b<c) && Math.Pow(c, 2).Equals(Math.Pow(a,2) + Math.Pow(b, 2));
        }

        public static List<long> AllFactorOf(long number)
        {
            List<long> factors = new List<long> { };
            for (long factor = 1; factor * factor <= number; factor++)
            {
                if (number % factor == 0)
                {
                    factors.Add(factor);
                    factors.Add(number / factor);
                }
            }
            return factors;
        }

        public static int[,] CreateMatrixOfIntegers(string[] content)
        {
            string[] row = new string[] { };
            int[,] MatrixOut = new int[20,20];
            for (int i = 0; i < content.Length; i++)
            {
                row = content[i].Split(' ');
                for(int j = 0; j < row.Length; j++)
                {
                    if (!int.TryParse(row[j], out MatrixOut[i,j]))
                    {
                        MatrixOut[i,j] = 0;
                    }
                }
            }
            return MatrixOut;
        }

        public static long collateLength(long Number)
        {
            long count = 1;

            while(Number != 1)
            {
                if(Number % 2 == 0)
                {
                    Number = Number / 2;
                    count++;
                }
                else
                {
                    Number = (3 * Number) + 1;
                    count++;
                }
            }
            return count;
        }
        public static long collateLength(long Number, Dictionary<long, long> collateCounts)
        {
            long count = 1;

            while (Number != 1)
            {
                if(collateCounts.ContainsKey(Number))
                {
                    count += collateCounts[Number];
                    return count;
                }

                if (Number % 2 == 0)
                {
                    Number = Number / 2;
                    count++;
                }
                else
                {
                    Number = (3 * Number) + 1;
                    count++;
                }
            }
            return count;
        }
    }
}
