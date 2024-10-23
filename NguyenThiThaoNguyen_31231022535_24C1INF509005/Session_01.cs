using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiThaoNguyen_31231022535_24C1INF509005
{
    internal class Session_01
    {
        public static void Main1()
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
            //Question_07();
            //Question_08();
            Question_09();
            //Question_10();
        }
        public static void Question_01()
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");
        }
        public static void Question_02()
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            (a, b) = (b, a);
            Console.WriteLine($"{a} {b}");
        }
        public static void Question_03()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = a * b;
            Console.WriteLine($"{a}*{b}={a * b}");
        }
        public static void Question_04()
        {
            Console.Write("Nhap so feet: ");
            double f = double.Parse(Console.ReadLine());
            double m = f * 0.3048;
            Console.WriteLine($"Doi sang met: {m}");
        }
        public static void Question_05()
        {
            Console.Write("Nhap do celcius: ");
            double c = double.Parse(Console.ReadLine());
            double f = c * 9 / 5 + 32;
            Console.WriteLine($"Doi sang farenheit: {f}");

            Console.Write("Nhap do farenheit: ");
            double f2 = double.Parse(Console.ReadLine());
            double c2 = (f2 - 32) * 5 / 9;
            Console.WriteLine($"Doi sang celcius: {c2}");

        }
        public static void Question_06()
        {
            int s = sizeof(int);
            Console.WriteLine($"{s}");

        }
        public static void Question_07()
        {
            char c = 'a';
            int num = c;
            Console.WriteLine($"{c} in ASCII = {num}");
        }

        public static void Question_08()
        {
            Console.Write("Nhap ban kinh: ");
            float r = float.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($" Dien tich hinh tron: {area}");
        }
        public static void Question_09()
        {
            Console.Write("Nhap canh: ");
            float a = float.Parse(Console.ReadLine());
            double area = Math.Pow(a, 2);
            Console.WriteLine($"Dien tich hinh vuong: {area}");
        }
        public static void Question_10()
        {
            Console.Write("Nhap so ngay: ");
            int d = int.Parse(Console.ReadLine());
            int n = d / 365;
            int t = (d - n * 365) / 7;
            int ngayle = (d - n * 365) % 7;
            Console.WriteLine($"{d} ngay bang {n} nam, {t} tuan va {ngayle} ngay le");
        }
    }
}
