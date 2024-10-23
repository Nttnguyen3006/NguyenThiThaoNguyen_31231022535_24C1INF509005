using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiThaoNguyen_31231022535_24C1INF509005
{
    internal class Session_03
    {
        public static void Main()
        {
            //Ex_01();
            Ex_03();
            Console.ReadKey();
        }
        public static void Ex_01()
        {
            do
            { Random rnd = new Random();
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
                } 
            }while (true);
         }

        public static void Ex_02()
            {
                Console.Write("Nhap mot so: ");
                int i = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} la so chan");
                }
                else
                {
                    Console.WriteLine($"{i} la so le");
                }
            }
        public static void Ex_03()
        {
            Console.Write("Nhap so 1: ");
            int a=int.Parse(Console.ReadLine());
            Console.Write("Nhap so 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so 3: ");
            int c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a>c)
                {
                    Console.WriteLine($"{a} la so lon nhat");
                }
                else { Console.WriteLine($"{c} la so lon nhat"); }
            }
            else if (b>c) { Console.WriteLine($"{b} la so lon nhat"); }
            else { Console.WriteLine($"{c} la so lon nhat"); }
        }
        }
    }

