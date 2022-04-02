using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            int[,] b;
            int[,] c;
            int m, n;
            NhapMang(out a, out b, out c, out m, out n);
            PhepCongMaTrix(a, b, c, m, n);


        }
        static void NhapMang(out int[,] a, out int[,] b, out int[,] c, out int m, out int n)
        {
            Console.WriteLine("Nhap m, n: ");
            string[] token = Console.ReadLine().Split();
            m = int.Parse(token[0]);
            n = int.Parse(token[1]);
            a = new int[m, n];
            b = new int[m, n];
            c = new int[m, n];


            for (int i = 0; i < m; i++)
            {
                token = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(token[j]);

                }
            }
            for (int i = 0; i < m; i++)
            {
                token = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = int.Parse(token[j]);

                }
            }
        }
        static void PhepCongMaTrix(int[,] a, int[,] b, int[,] c, int m, int n)
        {

            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];

                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
