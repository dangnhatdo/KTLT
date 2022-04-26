using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_3
{
    internal class Program
    {
        static int n, k;
        static int[] ToHop;
        static bool[] Check;
        static void Print()
        {
            for (int j = 1; j <= k; j++)
                Console.Write(ToHop[j] + " ");
            Console.WriteLine();
        }
        static void Checked()
        {
            for (int i = 1; i <= n; i++)
                Check[i] = true;
        }
        static void Try(int i)
        {
            for (int j = ToHop[i - 1]; j <= n - k + i; j++)
            {
                if (Check[j] == true)
                {
                    ToHop[i] = j;
                    Check[j] = false;
                    Try(i + 1);
                    Check[j] = true;
                    if (i == k)
                        Print();
                }
            }
        }
        static int GiaiThua(int n)
        {
            int GiaiThua = 1;
            for (int i = 2; i <= n; i++)
            {
                GiaiThua *= i;
            }
            return GiaiThua;
        }
        static int TinhToHop(int n, int k)
        {
            return GiaiThua(n) / (GiaiThua(k) * GiaiThua(n - k));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n, k: ");
            string[] token = Console.ReadLine().Split();
            n = int.Parse(token[0]);
            k = int.Parse(token[1]);

            Check = new bool[n + 1];
            ToHop = new int[n + 1];
            Checked();
            Console.WriteLine(TinhToHop(n, k));
            Try(1);
            Console.ReadKey();
        }
    }
}
