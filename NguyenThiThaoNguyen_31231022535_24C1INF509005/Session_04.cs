using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiThaoNguyen_31231022535_24C1INF509005
{
    internal class Session_04
    {
        /* public static void swap(ref int a, ref int b)
         { int temp=a; a=b; b=temp;}
         public static void Main(string[] args)
         {
             int a = 6;
             int b = 7;
             Console.WriteLine($"Before call: a={a}, b={b} ");
             swap(ref a,ref b);
             Console.Write($"After call: a={a}, b={b}");
         }
         public static void */

        static int maxofthreenumbers(int a, int b, int c)
        {
          return Math.Max(Math.Max(a,b), c);
        }
        static void Main41(string[] args)
        {
            int m = maxofthreenumbers(5, 2, 4);
            Console.WriteLine(m);
            Console.ReadKey();
        }
        static int Factorial(int n) // Hàm Factorial nhận một số nguyên n và trả về giai thừa của nó
        {
            if (n < 0)
                throw new ArgumentException("Factorial is not defined for negative numbers.");//báo lỗi khi n<0

            if (n == 0 || n == 1)
                return 1;

            return n * Factorial(n - 1);
        }

        static void Main42(string[] args)
        {
            Console.Write("Nhap mot so: ");
            int a = int.Parse(Console.ReadLine());
            int fac = Factorial(a);
            /* cách 2
            int a = 5;
            int result = Factorial(a)*/
            Console.WriteLine($"{a}! = {fac} ");
            Console.ReadKey();
        }
        static bool isPrime(int a)
        {
            if (a < 2) return false;
            for (int i = 2; i <= a / 2; i++)
                if (a % i == 0) return false;
            return true;
        }
        static void Main43(string[] args)
        {
            Console.Write("Input a number : ");
            int n = int.Parse(Console.ReadLine());
            if (isPrime(n))
            {
                Console.WriteLine(n + " is a prime number");
            }
            else
            {
                Console.WriteLine(n + " is not a prime number");
            }
        }
        static void printPrimeNumberUnderN(int n)
        {
            for (int i = 2; i <= n; i++)
                if (isPrime(i)) Console.WriteLine(i);
        }

        static void printFirstNPrime(int n)
        {
            int so = 2;
            int dem = 0;
            while (dem < n)
            {
                if (isPrime(so))
                {
                    Console.Write(so + " ");
                    dem++;
                }
                so++;
            }
        }
        static void Main44(string[] args)
        {
            printPrimeNumberUnderN(50);
            printFirstNPrime(10);
            Console.ReadKey();
        }
        static bool IsPerfectNumber(int number)
        {
            int sum = 0;

            // Tính tổng các ước số của số đó
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }

        static void Main45(string[] args)
        {
            Console.Write("Perfect numbers less than 1000:");

            for (int i = 1; i < 1000; i++)
            {
                if (IsPerfectNumber(i))
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadKey();
        }
        static bool IsPangram(string input)
        {
            // Chuyển đổi chuỗi thành chữ thường để kiểm tra không phân biệt chữ hoa và chữ thường
            string lowerInput = input.ToLower();

            for (char c = 'a'; c <= 'z'; c++)
            {
                // Dấu ! đảo ngược giát trị boolean, nếu 1 chữ ko có trong chuỗi thì false
                if (!lowerInput.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }

        static void Main46(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            if (IsPangram(sentence))
            {
                Console.WriteLine("The sentence is a pangram.");
            }
            else
            {
                Console.WriteLine("The sentence is not a pangram.");
            }

            Console.ReadKey();
        }
    }
}
