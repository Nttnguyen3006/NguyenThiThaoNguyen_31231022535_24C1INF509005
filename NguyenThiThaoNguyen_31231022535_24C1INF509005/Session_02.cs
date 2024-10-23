using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiThaoNguyen_31231022535_24C1INF509005
{
    internal class Session_02
    {
        public static void Main()
        {
            //Question_01();
            Question_06();
            Console.ReadKey();
        }
        public static void Question_01()
        {
            Console.Write("Nhap do celcius: ");
            int c = int.Parse(Console.ReadLine());
            int kelvin;
            int fahren;
            kelvin = c + 273;
            fahren = c * 9 / 5 + 32;
            Console.WriteLine($"Do Kelvin: {kelvin}, Do Fahrenheit: {fahren}");
        }
        public static void Question_02()
        {
            Console.Write("Nhap ban kinh r: ");
            float r = float.Parse(Console.ReadLine());
            double surface, volume;
            surface = 4 * Math.PI * Math.Pow(r, 2);
            volume = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Surface= {surface}, Volume= {volume}");
        }
        public static void Question_03()
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int c, t, n, ch, mo;
            c = a + b;
            t = a - b;
            n = a * b;
            ch = a / b;
            mo = a % b;
            Console.WriteLine($"Ket qua cong: {c}, tru: {t}, nhan: {n}, chia: {ch}, chia lay du: {mo}");
        }
        public static void Question_04()
        {
            int x, y;
            Console.WriteLine("x= y^2 - 2y + 1");
            for (y=-5; y<=5; y++)
            { x = y * y - 2 * y + 1;
                Console.WriteLine($"y={y}; x={y}^2-2*({y})+1={x}");
            }
        }
        public static void Question_05()
        {
            Console.Write("Nhap khoang cach (met): "); 
            float distance=float.Parse(Console.ReadLine());
            Console.Write("Nhap thoi gian (hour): ");
            float hour=float.Parse(Console.ReadLine());
            Console.Write("Nhap thoi gian (minutes): ");
            float min=float.Parse(Console.ReadLine());
            Console.Write("Nhap thoi gian (seconds): ");
            float sec=float.Parse(Console.ReadLine());
            float timeSec,mps,kph,mph;

            timeSec = (hour * 3600) + (min * 60) + sec;
            mps = distance / timeSec;
            kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            mph = kph / 1.609f;
            Console.WriteLine($"Your speed in meters/sec is {mps}");
            Console.WriteLine($"Your speed in km/h is {kph}");
            Console.WriteLine($"Your speed in miles/h is {mph}");
        }
        public static void Question_06()
        {
            Console.Write("Nhap mot ky tu: ");
            char symbol=char.Parse(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
            (symbol == 'o') || (symbol == 'u'))
            {
                Console.WriteLine("It's a lowercase vowel.");
            }
            else if ((symbol >= '0') && (symbol <= '9'))
            {
                Console.WriteLine("It's a digit.");
            }
            else
            {
                Console.WriteLine("It's another symbol.");
            }
        }
    }
}
