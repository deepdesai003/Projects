using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class Project
    {
        /// <summary>
        /// Main Console application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter Program Number in Numeric:");
            input = Console.ReadLine();
            while(!input.Equals("Exit",StringComparison.OrdinalIgnoreCase)) {
                switch (input)
                {
                    case "1":
                        Program1();
                        break;
                    case "2":
                        Program2();
                        break;
                    case "3":
                        Program3();
                        break;
                    case "5":
                        Program5();
                        break;
                    case "6":
                        Program6();
                        break;
                    case "7":
                        Program7();
                        break;
                    case "8":
                        Program8();
                        break;
                    case "9":
                        Program9();
                        break;
                    case "10":
                        Program10();
                        break;
                    case "11":
                        Program11();
                        break;
                    case "12":
                        Program12();
                        break;
                    case "13":
                        Program13();
                        break;
                    case "14":
                        Program14();
                        break;
                    case "15":
                        Program15();
                        break;
                    case "16":
                        Program16();
                        break;
                    case "17":
                        Program17();
                        break;
                    default:
                        Console.WriteLine("Wrong Entry! Try Again!!!");
                        break;
                }
                Console.WriteLine("Enter Program Number in Numeric:");
                input = Console.ReadLine();
            }
        }

        /// <summary>
        /// Solution for Program 1
        /// </summary>
        public static void Program1()
        {
            Console.WriteLine("Enter the Maximum Number.");
            Console.WriteLine(Program1to10.sumOfMultiplesof3and5(Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine("End of Function.");
        }

        /// <summary>
        /// Solution for Program 2
        /// </summary>
        public static void Program2()
        {
            Console.WriteLine("Sum of Even Fibnumber is: ");
            Console.WriteLine(Program1to10.sumofEvenFib());
            Console.WriteLine("End of Function:");
        }

        /// <summary>
        /// Solution for Program 2
        /// </summary>
        public static void Program3()
        {
            Console.WriteLine("Enter you number: ");
            Console.WriteLine(Program1to10.largestPrimeFactor(Convert.ToInt64(Console.ReadLine())));
            Console.WriteLine("End of Function:");
        }

        public static void Program5()
        {
            {
                Console.WriteLine("Smallest positive number evenly disvisible by all number from 1 to 20");
                Console.WriteLine(Program1to10.SmallestMultiple(20));
                Console.WriteLine("End of Function:");
            }
        }

        public static void Program6()
        {
            {
                Console.WriteLine("Largest Square Difference:");
                Console.WriteLine("Enter your number:");
                Console.WriteLine(Program1to10.LargestSquareDifference(Convert.ToInt32(Console.ReadLine())));
            }
        }

        public static void Program7()
        {
            {
                Console.WriteLine("Nth Prime Number:");
                Console.WriteLine("Enter the position of Prime Number needed:");
                Console.WriteLine(Program1to10.NthPrimeNumber(Convert.ToInt32(Console.ReadLine())));
            }
        }


        public static void Program8()
        {
            Console.WriteLine("Reading from file:");
            string series = Helper.readFromFile(@"C:\Users\ddesai\Desktop\1000DigitNumber");
            Console.WriteLine("Series read from file sucessful.");
            Console.WriteLine("Enter the number of cosecutive number whos product we want");
            Console.WriteLine(Program1to10.LargestProductInSeries(series, Convert.ToInt32(Console.ReadLine())));

        }

        public static void Program9()
        {
            Console.WriteLine("Special Pythagorean triplet");
            Console.WriteLine("Enter the sum of three numbers:");
            Console.WriteLine(Program1to10.SpecialPythagoreanTripletProduct(Convert.ToInt32(Console.ReadLine())));

        }
        public static void Program10()
        {
            Console.WriteLine("Summation of Primes:");
            Console.WriteLine("Enter Max Limit");
            Console.WriteLine(Program1to10.sumationOfPrimes(Convert.ToInt64(Console.ReadLine())));
            Console.WriteLine("End:");
        }

        public static void Program11()
        {
            Console.WriteLine("Enter File Location:");
            string[] fileContent = Helper.readLinesFromFile(FileName: Console.ReadLine());
            Console.WriteLine("Read from file sucessful.");
            int[,] grid = Helper.CreateMatrixOfIntegers(fileContent);
            Console.WriteLine("Grid Created");
            Console.WriteLine("Enter the number of numbers you want to multiple.");
            Console.WriteLine(Program2to20.LargestProductInMatrix(grid, noOfNumbers: Convert.ToInt32(Console.ReadLine())));
        }

        public static void Program12()
        {
            Console.WriteLine("Highly divisible triangular Number:");
            Console.WriteLine("Enter the number of divisors we want:");
            Console.WriteLine(Program2to20.highlyDivisibleTriangleNumbers(Convert.ToInt64(Console.ReadLine())));
        }

        public static void Program13()
        {
            Console.WriteLine("Reading from file:");
            string[] LargeNumbers = Helper.readLinesFromFile(@"C:\Users\ddesai\Desktop\LargeSum.txt");
            Console.WriteLine("File read sucessful.");
            Console.WriteLine(Program2to20.LargeSum(LargeNumbers));
        }

        public static void Program14()
        {
            Console.WriteLine("Longest Collatz Sequence:");
            Console.WriteLine("Enter the number under:");
            Console.WriteLine(Program2to20.LongestCollatzSequenceUsingHashTable(Convert.ToInt64(Console.ReadLine())));
        }

        public static void Program15()
        {
            Console.WriteLine("Lattice paths:");
            Console.WriteLine("Enter Grid size:");
            Console.WriteLine("No of Lattice paths is : " + Program2to20.LatticePaths(Convert.ToInt32(Console.ReadLine())));
        }
        public static void Program16()
        {
            Console.WriteLine("Power Digit Sum:");
            Console.WriteLine("Enter the Power:");
            Console.WriteLine("Sum of digits: " + Program2to20.SumOfDigits(Convert.ToInt32(Console.ReadLine())));
        }

        public static void Program17()
        {
            Console.WriteLine("Number Letter Count:");
            Console.WriteLine("Enter the maxLimit:");
            Console.WriteLine("Sum of letter: " + Program2to20.AllNumberLetterCount(Convert.ToInt32(Console.ReadLine())));
        }
    }
}
