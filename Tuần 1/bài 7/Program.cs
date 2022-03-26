using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine($"a[{i},{j}]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            MainCross(a);
            SideCross(a);
            TamGiac(a);
        }
        static void MainCross(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write(a[i, i] + " ");
            }
            Console.WriteLine();
        }
        static void SideCross(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i + j == a.GetLength(0) - 1)
                    {
                        Console.WriteLine(a[i, j]);
                    }
                }
            }
            Console.WriteLine();
        }
        static void TamGiac(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = i; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
