using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_4
{
    internal class Program
    {
        static int n;
        static int[] Solution;
        static int Count = 0;
        static bool Check(int x, int y)
        {
            for (int i = 1; i < x; i++)
                if (Solution[i] == y || Math.Abs(i - x) == Math.Abs(Solution[i] - y))
                    return false;
            return true;
        }
        static void Print(int n)
        {
            Console.Write($"Solution {Count}: ");
            for (int i = 1; i <= n; i++)
                Console.Write(Solution[i] + " ");
            Console.WriteLine();
        }
        static void Try(int i, int n)
        {
            for (int j = 1; j <= n; j++)
            {
                if (Check(i, j))
                {
                    Solution[i] = j;
                    if (i == n)
                    {
                        Count += 1;
                        Print(n);
                    }
                    Try(i + 1, n);
                }
            }
        }
        static void Main(string[] args)
        {
            n = 8;
            Solution = new int[n + 1];
            Try(1, n);
            Console.ReadKey();
        }
    }
}
