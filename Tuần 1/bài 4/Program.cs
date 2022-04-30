using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap m, n, k: ");
            string[] token = Console.ReadLine().Split();
            int m = int.Parse(token[0]);
            int n = int.Parse(token[1]);
            int k = int.Parse(token[2]);

            int[,] a;
            a = new int[m, n];
            NhapMang(a);
            XuatMang(a);
            Console.WriteLine(K4a(a, ref k));
            Console.WriteLine(K4b(a, ref k));
            Console.WriteLine(K4c(a));
            Console.WriteLine(K4d(a));
            Console.WriteLine(K4e(a));
            Console.WriteLine(K4f(a));


        }
        static void NhapMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}]= ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
         static int K4a(int[,] a, ref int k)
         {
             int sum = 0;
             for (int i = k; i == k; i++)
             {
                 for (int j = 0; j < a.GetLength(1); j++)
                 {                  
                     sum += a[i, j];
                 }                      
             }
            return sum;
         }
        static int K4b(int[,] a, ref int k)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = k; j == k; j++)
                {                  
                    sum += a[i, j];
                }
                          
            }
           return sum;
        }
        static int K4c(int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                }
            }  
           return sum;
        }
        static int K4d(int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {                    
                    if (a[i, j] % 2 == 0)
                    {
                        sum += a[i, j];
                    }
                }              
            }
           return sum;
        }
        static int K4e(int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {   
                    if (a[i, j] % 2 != 0)
                    {
                        sum += a[i, j];
                    }
                }
            }
           return sum;
        }
        static double K4f(int[,] a)
        {
            int sum = 0;

            double TBC = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                }
            }
            TBC = (double)sum / a.Length;
           return TBC;
        }
    }
}
