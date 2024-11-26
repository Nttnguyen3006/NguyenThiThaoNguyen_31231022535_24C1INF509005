using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiThaoNguyen_31231022535_24C1INF509005
{
    internal class Session_07
    {
        static void Main7(string[] args)
        {
            // 1. Khởi tạo mảng Jagged và hiển thị
            int[][] jaggedArray = new int[4][]; // Mảng Jagged với 4 hàng
            jaggedArray[0] = new int[] { 1, 1, 1, 1, 1 };
            jaggedArray[1] = new int[] { 2, 2 };
            jaggedArray[2] = new int[] { 3, 3, 3, 3 };
            jaggedArray[3] = new int[] { 4, 4 };

            Console.WriteLine("Jagged Array (Pre-defined):");
            PrintJaggedArray(jaggedArray);

            // 2. Tạo mảng Jagged với giá trị ngẫu nhiên
            Console.WriteLine("\nEnter the number of rows for the Jagged Array:");
            int rows = int.Parse(Console.ReadLine());
            int[][] randomJaggedArray = CreateRandomJaggedArray(rows);

            Console.WriteLine("\nGenerated Random Jagged Array:");
            PrintJaggedArray(randomJaggedArray);

            // 3. Thực hiện các chức năng trên mảng Jagged
            Console.WriteLine("\nBiggest number in each row:");
            PrintMaxOfEachRow(randomJaggedArray);

            Console.WriteLine("\nSorting each row in ascending order (Sap xep tang dan)...");
            SortRowsAscending(randomJaggedArray);
            PrintJaggedArray(randomJaggedArray);

            Console.WriteLine("\nPrime numbers in the array:");
            PrintPrimesInJaggedArray(randomJaggedArray);

            Console.WriteLine("\nEnter a number to search:");
            int searchNumber = int.Parse(Console.ReadLine());
            SearchAndPrintPositions(randomJaggedArray, searchNumber);
        }

        // Function to create a random jagged array
        static int[][] CreateRandomJaggedArray(int rows)
        {
            Random random = new Random();
            int[][] jaggedArray = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Enter the number of elements in row {i + 1}:");
                int cols = int.Parse(Console.ReadLine());
                jaggedArray[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    jaggedArray[i][j] = random.Next(1, 101); // Random numbers from 1 to 100
                }
            }
            return jaggedArray;
        }

        // Function to print a jagged array
        static void PrintJaggedArray(int[][] jaggedArray)
        {
            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        // Function to print the largest number in each row
        static void PrintMaxOfEachRow(int[][] jaggedArray)
        {
            foreach (var row in jaggedArray)
            {
                int max = row.Max();
                Console.WriteLine($"Max of row: {max}");
            }

            int globalMax = jaggedArray.SelectMany(row => row).Max();
            Console.WriteLine($"Largest number in the entire array: {globalMax}");
        }

        // Function to sort rows in ascending order
        static void SortRowsAscending(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Array.Sort(jaggedArray[i]);
            }
        }

        // Function to print all prime numbers in the jagged array
        static void PrintPrimesInJaggedArray(int[][] jaggedArray)
        {
            foreach (var row in jaggedArray)
            {
                foreach (var num in row)
                {
                    if (IsPrime(num))
                    {
                        Console.Write(num + " ");
                    }
                }
            }
            Console.WriteLine();
        }

        // Helper function to check if a number is prime
        static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        // Function to search for a number and print its positions
        static void SearchAndPrintPositions(int[][] jaggedArray, int searchNumber)
        {
            bool found = false;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] == searchNumber)
                    {
                        Console.WriteLine($"Found {searchNumber} at row {i + 1}, column {j + 1}");
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine($"{searchNumber} not found in the array.");
            }
        }
    }
}
