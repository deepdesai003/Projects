namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Diagnostics;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;
    using System.Collections;
    using System.IO;

    public class Program2to20
    {
        public static long highlyDivisibleTriangleNumbers(long numOfDivisors)
        {
            List<long> triangleNumbers = new List<long> { };

            triangleNumbers.Add(1);
            triangleNumbers.Add(3);
            //check divisors;
            while (numOfDivisors > Helper.AllFactorOf(triangleNumbers.Last()).Count())
            {
                triangleNumbers.Add(triangleNumbers.Last() + triangleNumbers.LastIndexOf(triangleNumbers.Last()) + 2);
            }
            return triangleNumbers.Last();
        }

        public static long LargestProductInMatrix(int[,] grid, int noOfNumbers)
        {
            long currentProduct = 1;
            long MaxProduct = 1;
            try
            {
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    for (int j = 0; j < grid.GetLength(1); j++)
                    {

                        for (int direction = 1; direction <= 4; direction++)
                        {
                            if (currentProduct == 0)
                            {
                                currentProduct = 1;
                            }

                            for (int k = 0; k < noOfNumbers; k++)
                            {
                                if (direction == 1)
                                {
                                    //straight Center to East
                                    if ((j + k) > grid.GetLength(1) - 1)
                                    {
                                        currentProduct = 0;
                                        break;
                                    }
                                    currentProduct = currentProduct * grid[i, j + k];
                                    Debug.WriteLine(grid[i, j + k]);
                                }

                                if (direction == 2)
                                {
                                    //Diagnol center to NE
                                    if ((i - k) < 0 || (j + k) > grid.GetLength(1) - 1)
                                    {
                                        currentProduct = 0;
                                        break;
                                    }
                                    currentProduct = currentProduct * grid[i - k, j + k];
                                    Debug.WriteLine(grid[i - k, j + k]);
                                }


                                if (direction == 3)
                                {
                                    if ((i + k) > grid.GetLength(1) - 1)
                                    {
                                        currentProduct = 0;
                                        break;
                                    }
                                    //Stright center to South
                                    currentProduct = currentProduct * grid[i + k, j];
                                    Debug.WriteLine(grid[i + k, j]);
                                }

                                if (direction == 4)
                                {
                                    if ((i + k) > grid.GetLength(0) - 1 || (j + k) > grid.GetLength(1) - 1)
                                    {
                                        currentProduct = 0;
                                        break;
                                    }
                                    //Diagnol center SE
                                    currentProduct = currentProduct * grid[i + k, j + k];
                                    Debug.WriteLine(grid[i + k, j + k]);
                                }
                            }

                            if (currentProduct > MaxProduct)
                            {
                                Debug.WriteLine(currentProduct);
                                MaxProduct = currentProduct;
                            }

                            if (currentProduct != 0)
                            {
                                currentProduct = 1;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return MaxProduct;
        }

        public static BigInteger LargeSum(string[] largeNumbers)
        {
            BigInteger result = 0;
            largeNumbers.ToList().ForEach(largeNumber => { result += BigInteger.Parse(largeNumber); });
            return result;
        }

        public static long LongestCollatzSequence(long maxLimit)
        {
            long max = 0;
            long currentCollageCount = 0;
            for (long i = 1; i < maxLimit; i++)
            {
                currentCollageCount = Helper.collateLength(i);
                Debug.WriteLine(i);
                if (currentCollageCount > max)
                {
                    Console.WriteLine("Number: " + i + "Max: " + currentCollageCount);
                    max = currentCollageCount;
                }
            }
            return max;
        }

        public static long LongestCollatzSequenceUsingHashTable(long maxLimit)
        {
            long max = 0;
            long currentCollageCount = 0;
            Dictionary<long, long> CollateCounts = new Dictionary<long, long>();
            for (long i = 1; i < maxLimit; i++)
            {
                currentCollageCount = Helper.collateLength(i, CollateCounts);
                if (!CollateCounts.ContainsKey(i))
                {
                    CollateCounts.Add(i, currentCollageCount);
                }
                Debug.WriteLine(i);
                if (currentCollageCount > max)
                {
                    Console.WriteLine("Number: " + i + "Max: " + currentCollageCount);
                    max = currentCollageCount;
                }
            }
            return max;
        }

        public static long LatticePaths(int gridSize)
        {
            long[,] grid = new long[gridSize + 1, gridSize + 1];

            for (int i = 1; i <= gridSize; i++)
            {
                grid[0, i] = 1;
                grid[i, 0] = 1;
            }

            for (int i = 1; i <= gridSize; i++)
            {
                for (int j = 1; j <= gridSize; j++)
                {
                    try
                    {
                        grid[i, j] = grid[i, j - 1] + grid[i - 1, j];
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return grid[gridSize, gridSize];
        }

        public static BigInteger SumOfDigits(int pow)
        {
            BigInteger sum = 0;

            string series = BigInteger.Pow(2, pow).ToString();
            for (int i = 0; i < series.Length; i++)
            {
                sum += (int)char.GetNumericValue(series[i]);
            }
            return sum;
        }

        public static int NumberLetterCount(int inputNumber)
        {
            int count = 0;

            int[] num1to19 = new int[]
            {
                0,
                "one".Length,
                "two".Length,
                "three".Length,
                "four".Length,
                "five".Length,
                "six".Length,
                "seven".Length,
                "eight".Length,
                "nine".Length,
                "ten".Length,
                "eleven".Length,
                "twelve".Length,
                "thirteen".Length,
                "fourteen".Length,
                "fifteen".Length,
                "sixteen".Length,
                "seventeen".Length,
                "eighteen".Length,
                "ninteen".Length,
            };

            int[] numtenths = new int[]
            {
                0,
                0,
                "twenty".Length,
                "thirty".Length,
                "forty".Length,
                "fifty".Length,
                "sixty".Length,
                "seventy".Length,
                "eighty".Length,
                "ninety".Length
            };

            if (inputNumber < 20)
            {
                count += num1to19[inputNumber % 20];
            }

            if ((inputNumber >= 20) && (inputNumber <= 99))
            {
                count += numtenths[inputNumber / 10] + num1to19[inputNumber % 10];
            }
            if ((inputNumber > 99) && (inputNumber <= 999))
            {
                int twoDigitNumber = inputNumber % 100;

                if (twoDigitNumber.Equals(0))
                {
                    count = count + num1to19[inputNumber / 100] + "hundred".Length;
                }
                else
                {
                    count = count + num1to19[inputNumber / 100] + "hundredand".Length;

                    if (twoDigitNumber < 20)
                    {
                        count += num1to19[twoDigitNumber % 20];
                    }
                    if ((twoDigitNumber >= 20) && (twoDigitNumber <= 99))
                    {
                        count += numtenths[twoDigitNumber / 10] + num1to19[twoDigitNumber % 10];
                    }
                }
            }

            if (inputNumber == 1000)
            {
                count += "onethousand".Length;
            }
            return count;
        }

        public static int AllNumberLetterCount(int MaxLimit)
        {
            int count = 0;
            while (MaxLimit > 0)
            {
                count += NumberLetterCount(MaxLimit);
                MaxLimit--;
            }

            return count;
        }
    }
}
