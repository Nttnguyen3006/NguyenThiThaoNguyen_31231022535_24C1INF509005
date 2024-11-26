using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiThaoNguyen_31231022535_24C1INF509005
{
    internal class Session_06
    {
        static int[,] NhapNgauNhien(int rows, int cols)
        {
            Random rnd = new Random();
            int[,] a = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    a[i, j] = rnd.Next(0, 100);
                }
            }
            return a;
        }
        static void InMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void InHangHoacCot(int[,] a, int index, bool isRow)
        {
            
            if (isRow)
            {
                // Print the i-th row
                if (index >= 0 && index < a.GetLength(0))
                {
                    for (int j = 0; j < a.GetLength(0); j++)
                    {
                        Console.Write(a[index, j] + "\t");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid row index.");
                }
            }
            else
            {
                // Print the i-th column
                if (index >= 0 && index < a.GetLength(1))
                {
                    for (int i = 0; i < a.GetLength(1); i++)
                    {
                        Console.Write(a[i, index] + "\t");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid column index.");
                }
            }
        }
        static int FindMax(int[,] a)
        {
            int max = a[0, 0];
            foreach (var value in a)
            {
                if (value > max)
                    max = value;
            }
            return max;
        }
        static int FindMinInRowOrColumn(int[,] a, int index, bool isRow)
        {
            if (isRow && (index < 1 || index > a.GetLength(0)))
            {
                throw new ArgumentException($"Invalid row index. Please enter a number between 1 and {a.GetLength(0)}.");
            }
            else if (!isRow && (index < 1 || index > a.GetLength(1)))
            {
                throw new ArgumentException($"Invalid column index. Please enter a number between 1 and {a.GetLength(1)}.");
            }
            
            int min;
            /* cach tim min trong hang/cot 1:
             int min = isRow ? matrix[index, 0] : matrix[0, index];*/
            //cach 2:
            if (isRow)
            {
                // Tìm giá trị nhỏ nhất trong hàng 
                min = a[index, 0];
                for (int j = 1; j < a.GetLength(0); j++) // Đúng kích thước cột
                {
                    if (a[index, j] < min)
                        min = a[index, j];
                }
            
            }
            else
            {
                    min = a[0, index];
                    for (int i = 1; i < a.GetLength(1); i++) // Đúng kích thước hàng
                    {
                        if (a[i, index] < min)
                            min = a[i, index];
                    }
            }
            return min;
        }
        static void TransposeMatrix(int[,] transpose, int[,] a)
        {
            int rows = a.GetLength(0);
            int cols = a.GetLength(1);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    transpose[j, i] = a[i, j];
                }
            }
        }
        static void PrintDiagonals(int[,] a)
        {
            int size = Math.Min(a.GetLength(0), a.GetLength(1));

            Console.WriteLine("\nMain and secondary diagonals:");
            for (int i = 0; i < size; i++)
            {
                // Print main diagonal element
                Console.Write($"Main: {a[i, i]} ");

                // Print secondary diagonal element
                Console.WriteLine($"Secondary: {a[i, a.GetLength(1) - i - 1]}");
            }
        }
        static void Main6(string[] args)
        {
            // Step 1: Get matrix dimensions from the user
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            // Step 2: Create the matrix
            int[,] a = NhapNgauNhien(rows, cols);

            // Step 3: Print the matrix
            Console.WriteLine("\nOriginal Matrix:");
            InMang(a);

            // Step 4: Print specific row or column
            Console.Write("\nEnter the index (i) of the row/column you want to print: ");
            int index = int.Parse(Console.ReadLine());

            Console.Write("Do you want to print a row (r) or a column (c)? ");
            string choice = Console.ReadLine().ToLower();
            bool isRow = choice == "r";
            InHangHoacCot(a, index, isRow);

            // Step 5: Find max value in the matrix
            int max = FindMax(a);
            Console.WriteLine($"\nMax value in the matrix: {max}");

            // Step 6: Find min value in the i-th row/column
            Console.Write("\nEnter the index (i) of the row/column for min value search: ");
            index = int.Parse(Console.ReadLine());

            Console.Write("Do you want to find min in a row (r) or a column (c)? ");
            choice = Console.ReadLine().ToLower();
            isRow = choice == "r";
            int min = FindMinInRowOrColumn(a, index, isRow);
            Console.WriteLine($"Min value in the {(isRow ? "row" : "column")} {index}: {min}");

            // Step 7: Transpose the matrix
            int[,] transpose = new int[a.GetLength(1), a.GetLength(0)];// Tạo ma trận chuyển vị
            TransposeMatrix( transpose, a);  // Gọi hàm TransposeMatrix để thay đổi transpose
            Console.WriteLine("\nTransposed Matrix:");
            InMang(transpose);

            // Step 8: Print diagonals
            PrintDiagonals(a);
        }
    }
}

