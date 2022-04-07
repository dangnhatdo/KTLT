using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] token = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(token[i]);
            }

            Console.WriteLine(Find_x(a, x, 0, a.Length - 1));
        }
        static int Find_x(int[] a, int x, int left, int right)
        {
            int mid = (left + right) / 2;
            while (left <= right)
            {
                if (a[mid] == x)
                {
                    return mid;
                }

                else if (x > a[mid])
                {
                    return Find_x(a, x, mid + 1, right);
                }
                else
                {
                    return Find_x(a, x, left, mid);
                }
            }
            return -1;

        }

    }
}
