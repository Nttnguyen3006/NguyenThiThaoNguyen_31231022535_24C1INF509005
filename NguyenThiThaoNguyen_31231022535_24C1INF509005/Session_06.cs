using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiThaoNguyen_31231022535_24C1INF509005
{
    internal class Session_06
    {
        public static int[,] TaoMaTran(int soDong, int soCot, int soNho, int soLon)
        {
            int[,] matran = new int[soDong, soCot];
            Random rand = new Random();
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {

                    matran[i, j] = rand.Next(soNho, soLon + 1);
                }
            }
            return matran;
        }

        public static void HienThiMaTran(int[,] matran)
        {
            int Dong = matran.GetLength(0);
            int Cot = matran.GetLength(1);

            for (int i = 0; i < Dong; i++)
            {
                for (int j = 0; j < Cot; j++)
                {
                    Console.Write($"{matran[i, j],5}");
                }
                Console.WriteLine();
            }
        }

        public static void InHangThuI(int[,] matran, int hang)
        {
            int Cot = matran.GetLength(1);
            if (hang < 0 || hang > matran.GetLength(0))
            {
                Console.WriteLine("Hang khong hop le");
                return;
            }
            Console.Write($"Hang thu {hang}: ");
            for (int j = 0; j < Cot; j++)
            {
                Console.Write($"{matran[hang, j],5}");
            }
            Console.WriteLine();
        }
        public static void InCotThuJ(int[,] matran, int cot)
        {
            int Dong = matran.GetLength(0);
            if (cot < 0 || cot > matran.GetLength(1))
            {
                Console.WriteLine("Hang khong hop le");
                return;
            }
            Console.Write($"Cot thu {cot}: ");
            for (int i = 0; i < Dong; i++)
            {
                Console.WriteLine($"{matran[i, cot],5}");
            }
            Console.WriteLine();
        }


        //In gia tri lon nhat trong ma tran
        public static int GiatriMax(int[,] matran)
        {
            int giatriMax = int.MinValue;
            for (int i = 0; i < matran.GetLength(0); i++)
            {
                for (int j = 0; j < matran.GetLength(1); j++)
                {
                    if (matran[i, j] > giatriMax)
                        giatriMax = matran[i, j];
                }
            }
            return giatriMax;
        }

        //In gia tri nho nhat trong ma tran
        public static int GiatriMin(int[,] matran)
        {
            int giatriMin = int.MaxValue;
            for (int i = 0; i < matran.GetLength(0); i++)
            {
                for (int j = 0; j < matran.GetLength(1); j++)
                {
                    if (matran[i, j] < giatriMin)
                        giatriMin = matran[i, j];
                }
            }
            return giatriMin;
        }

        public static void Giatrinhocuahang(int[,] matran)
        {
            Console.Write("Nhap so hang ma ban muon tim gia tri nho nhat: ");
            int giatriHang = int.Parse(Console.ReadLine());
            if (giatriHang < 0 || giatriHang > matran.GetLength(0))
            {
                Console.WriteLine("Hang khong hop le! Vui long nhap lai");
                return;
            }
            int giatriNho = matran[giatriHang, 0];
            for (int j = 1; j < matran.GetLength(1); j++)
            {
                if (matran[giatriHang, j] < giatriNho)
                    giatriNho = matran[giatriHang, j];
            }
            Console.WriteLine($"Gia tri nho nhat trong hang {giatriHang} la: {giatriNho}");

        }



        public static void Giatrinhocuacot(int[,] matran)
        {
            Console.Write("Nhap so cot ban tim gia tri nho nhat: ");
            int giatriCot = int.Parse(Console.ReadLine());
            if (giatriCot < 0 || giatriCot > matran.GetLength(0))
            {
                Console.WriteLine("Cot khong hop le! Vui long nhap lai");
                return;
            }
            int giatrinho = matran[0, giatriCot];
            for (int i = 1; i < matran.GetLength(1); i++)
            {
                if (matran[i, giatriCot] < giatrinho)
                    giatrinho = matran[i, giatriCot];
            }
            Console.WriteLine($"Gia tri nho nhat trong cot {giatriCot} la: {giatrinho}");
        }

        public static int[,] Chuyenvimatran(int[,] matran)
        {
            int soDong = matran.GetLength(0);
            int soCot = matran.GetLength(1);

            int[,] matranchuyenvi = new int[soCot, soDong];

            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    matranchuyenvi[j, i] = matran[i, j];
                }
            }
            return matranchuyenvi;
        }

        public static void InDuongCheo(int[,] matran)
        {
            int soDong = matran.GetLength(0);
            int soCot = matran.GetLength(1);

            if (soDong != soCot)
            {
                Console.WriteLine("Ma tran khong phai la ma tran vuong. Ma tran khong co duong cheo chinh và duong cheo phu");
                return;
            }
            Console.WriteLine("Cac gia tri tren duong cheo chinh");
            for (int i = 0; i < soDong; i++)
            {
                Console.WriteLine(matran[i, i] + "\t");

            }

            Console.WriteLine("Cac gia tri tren duong cheo phu");
            for (int i = 0; i < soDong; i++)
            {
                Console.WriteLine(matran[i, soDong - 1 - i] + "\t");
            }

        }
        public static void Main6()
        {
            Console.WriteLine("NHAP THONG TIN CHO MA TRAN");
            Console.Write("Nhap so dong: ");
            int sodong = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int socot = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri nho nhat: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri lon nhat: ");
            int max = int.Parse(Console.ReadLine());



            int[,] matran = TaoMaTran(sodong, socot, min, max);
            Console.WriteLine("Ma tran ngau nhien duoc tao: ");
            HienThiMaTran(matran);



            Console.WriteLine();
            Console.Write("IN HANG TRONG MA TRAN (bat dau tu 0): ");
            int hang = int.Parse(Console.ReadLine());
            InHangThuI(matran, hang);


            Console.WriteLine();
            Console.Write("IN COT TRONG MA TRAN( bat dau tu 0): ");
            int cot = int.Parse(Console.ReadLine());
            InCotThuJ(matran, cot);



            Console.WriteLine();
            Console.WriteLine("TIM GIA TRI MAX TRONG MA TRAN");
            int giatrilonnhat = GiatriMax(matran);
            Console.WriteLine($"Gia tri lon nhat trong ma tran: {giatrilonnhat}");


            Console.WriteLine();
            Console.WriteLine("TIM GIA TRI MIN THEO HANG TRONG MA TRAN");
            int giatrinhonhat = GiatriMin(matran);
            Console.WriteLine($"Gia tri nho nhat trong ma tran: {giatrinhonhat}");


            Console.WriteLine();
            Console.WriteLine("TIM GIA TRI MIN TRONG HANG DO NGUOI DUNG NHAP VAO");
            Giatrinhocuahang(matran);



            Console.WriteLine();
            Console.WriteLine("TIM GIA TRI MIN THEO COT TRONG MA TRAN");
            Giatrinhocuacot(matran);



            Console.WriteLine();
            Console.WriteLine("MA TRAN CHUYEN VI");
            int[,] matranChuyenVi = Chuyenvimatran(matran);
            Console.WriteLine("Ma tran sau khi chuyen vi: ");
            HienThiMaTran(matranChuyenVi);


            Console.WriteLine();
            Console.WriteLine("IN RA CAC DUONG CHEO CHINH VA DUONG CHEO PHU");
            InDuongCheo(matran);
            Console.ReadKey();
        }

    }
}

    