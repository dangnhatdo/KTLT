using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            int[,] b;
            int[,] c;
            int m, n, p;
            NhapMang(out a, out b, out c, out m, out n, out p);
            PhepNhanMaTrix(a, b, c, m, n, p);
        }
        static void NhapMang(out int[,] a, out int[,] b, out int[,] c, out int m, out int n, out int p)
        {
            Console.WriteLine("Nhap m, n, p : ");
            string[] token = Console.ReadLine().Split();
            m = int.Parse(token[0]);
            n = int.Parse(token[1]);
            p = int.Parse(token[2]);
            a = new int[m, n];
            b = new int[n, p];
            c = new int[m, p];

            for (int i = 0; i < m; i++)
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
                for (int j = 0; j < p; j++)
                {
                    b[i, j] = int.Parse(token[j]);
                }
            }
        }
        static void PhepNhanMaTrix(int[,] a, int[,] b, int[,] c, int m, int n, int p)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    c[i, j] = 0;

                    for (int k = 0; k < n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}