using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            int[,] b;
            int[,] c;
            int n, p;
            NhapMang(out a, out b, out c, out n, out p);
            PhepNhanMaTrix(a, b, c, n, p);
        }
        static void NhapMang(out int[,] a, out int[,] b, out int[,] c, out int n, out int p)
        {
            Console.WriteLine("Nhap n, p : ");
            string[] token = Console.ReadLine().Split();
            n = int.Parse(token[0]);
            p = int.Parse(token[1]);
            a = new int[1, n];
            b = new int[n, p];
            c = new int[1, p];

            for (int i = 0; i < 1; i++)
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
        static void PhepNhanMaTrix(int[,] a, int[,] b, int[,] c, int n, int p)
        {
            int sum = 0;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                    sum += c[i, j];
                }
            }
            Console.WriteLine(sum);
            for (int i = 0; i < 1; i++)
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