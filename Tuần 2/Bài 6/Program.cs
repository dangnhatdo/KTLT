using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            int[,] b;
            int n;
            NhapMang(out a, out b, out n);
            Console.WriteLine(Dot_Product(a, b, n));
        }
        static void NhapMang(out int[,] a, out int[,] b, out int n)
        {
            Console.WriteLine("Nhap n : ");
            string[] token = Console.ReadLine().Split();
            n = int.Parse(token[0]);
            a = new int[n, n];
            b = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                token = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(token[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                token = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = int.Parse(token[j]);
                }
            }
        }
        static int Dot_Product(int[,] a, int[,] b, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += a[i, j] * b[i, j];
                }
            }
            return sum;
        }
    }
}

