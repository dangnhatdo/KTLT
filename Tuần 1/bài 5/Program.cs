using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n, k;
            int[,] a;
            NhapMang(out m, out n, out k, out a);
            Console.WriteLine($"Phan tu lon nhat dong {k} la: {MaxRow(k, a)}");
            Console.WriteLine($"Phan tu be nhat cot {k} la: {MinCol(k, a)}");
            SNT(a);
            Console.ReadKey();
        }

        static void NhapMang(out int m, out int n, out int k, out int[,] a)
        {
            string[] token = Console.ReadLine().Split();
            m = int.Parse(token[0]);
            n = int.Parse(token[1]);
            k = int.Parse(token[2]);
            a = new int[m, n];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                  token = Console.ReadLine().Split();
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(token[j]);
                }
            }
        }

        static int MaxRow(int k, int[,] a)
        {
            int max = a[k, 0];
            for (int i = 0; i < a.GetLength(1); i++)
            {
                if (max < a[k, i])
                {
                    max = a[k, i];
                }
            }

            return max;
        }
        static int MinCol(int k, int[,] a)
        {
            int min = a[0, k];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (min > a[k, i])
                {
                    min = a[k, i];
                }
            }
            return min;
        }

        static int MaxArr(int[,] a)
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                    }
                }
            }

            return max;
        }
        static void SNT(int[,] a)
        {
            int max = MaxArr(a);
            int[] b = new int[max + 1];
            for (int h = 0; h <= max; h++)
            {
                b[h] = 0;// tạo bảng b gồm toàn phần tử 0
            }
            for (int h = 0; h <= max; h++)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (h == a[i, j])
                        {
                            b[h] = 1;
                        }
                    }
                }
            }
            for (int h = 0; h <= max; h++)
            {
                if (b[h] == 1)
                {
                    //nếu b[h] tăng lên thì tức là ko phải snt
                    for (int i = 2; i <= Math.Sqrt(h); i++)
                    {
                        if (h % i == 0)
                        {
                            b[h]++;
                        }
                    }
                }
            }

            Console.WriteLine("So nguyen to:");
            for (int i = 0; i <= max; i++)
            {
                if (b[i] == 1)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
