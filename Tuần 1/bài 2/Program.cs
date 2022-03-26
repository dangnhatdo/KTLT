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
            int m, n, k;
            NhapMang(out a, out m, out n, out k);
            if (k < 0 || k >= m)
            {
                Console.WriteLine("Invalid K");
            }
            else
            {
                FindK(a, k, n);
            }
        }
        static void NhapMang(out int[,] a, out int m, out int n, out int k)
        {
            Console.WriteLine("Nhap m, n, k: ");
            string[] token = Console.ReadLine().Split();
            m = int.Parse(token[0]);
            n = int.Parse(token[1]);
            k = int.Parse(token[2]);
            a = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                token = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(token[j]);
                }
            }
        }
        static void FindK(int[,] a, int k, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[k, i] + " ");
            }
            Console.WriteLine();
        }
    }
}
