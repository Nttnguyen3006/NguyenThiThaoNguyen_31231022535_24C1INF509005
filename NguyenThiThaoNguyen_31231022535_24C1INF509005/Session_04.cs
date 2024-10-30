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
        static void Main(string[] args)
        {
            int m = maxofthreenumbers(5, 2, 4);
            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}
