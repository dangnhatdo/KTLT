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
            int[,] a;
            int n, p;
            NhapMang(out a, out n, out p);
            ChuyenVi(a, n, p);
        }
        static void NhapMang(out int[,] a, out int n, out int p)
        {
            Console.WriteLine("Nhap n, p : ");
            string[] token = Console.ReadLine().Split();
            n = int.Parse(token[0]);
            p = int.Parse(token[1]);
            a = new int[n, p];

            for (int i = 0; i < n; i++)
            {
                token = Console.ReadLine().Split();
                for (int j = 0; j < p; j++)
                {
                    a[i, j] = int.Parse(token[j]);
                }
            }
        }
        static void ChuyenVi(int[,] a, int n, int p)
        {
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}