using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiThaoNguyen_31231022535_24C1INF509005
{
    internal class Session_03
    {
        public static void Main()
        {
            Random rnd = new Random();
            int comp_num = rnd.Next(0, 10) + 1;
            int count = 0;
            bool isContinue = true;
            do
            {
                count++;
                Console.Write("Ban doan so may? <1..10>: ");
                int user_num = int.Parse(Console.ReadLine());
                if (user_num == comp_num)
                {
                    Console.Write($"Ban doan trung sau {count} lan");
                    isContinue = false;
                }
                else
                {
                    if (user_num > comp_num)
                        Console.Write("so ban doan lon hon so may nghi");
                    else
                        Console.Write("so ban doan nho hon so may nghi");
                }
            } while (isContinue);
            Console.WriteLine("============");
            Console.Write("choi nua khong?<C/K>:");
            string tl = Console.ReadLine();
            if (tl.ToUpper().Equals("K")) ;
            {
                Console.Write("OK");
                return;
            } while (true) ;

        }
    }
}
