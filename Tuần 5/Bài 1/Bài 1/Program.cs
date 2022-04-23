using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    internal class Program
    {
        static int n, k;
        static int[] ChinhHopLap;
        static void Print()
        {
            for (int j = 1; j <= k; j++)
                Console.Write(ChinhHopLap[j] + " ");
            Console.WriteLine();
        }
        static void Try(int i)
        {
            for (int j = 1; j <= n; j++)
            {
                ChinhHopLap[i] = j;
                if (i == k)
                    Print();
                else
                    Try(i + 1);
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Nhap n, k: ");
            string[] token = Console.ReadLine().Split();
            n = int.Parse(token[0]);
            k = int.Parse(token[1]);
            ChinhHopLap = new int[n + 1];
            Console.WriteLine(Math.Pow(n, k));
            Try(1);
            Console.ReadKey();
        }
    }
}
