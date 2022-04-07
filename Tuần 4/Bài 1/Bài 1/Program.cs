using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] token = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {

                a[i] = int.Parse(token[i]);
            }

            Console.WriteLine(Find_min(a, 0, a.Length - 1));
            Console.WriteLine(Find_max(a, 0, a.Length - 1));
        }
        static int Find_min(int[] a, int left, int right)
        {
            if (left == right)
            {
                return a[left];
            }
            else
            {
                int mid = (left + right) / 2;
                int Min_left = Find_min(a, left, mid);
                int Min_right = Find_min(a, mid + 1, right);
                return Math.Min(Min_left, Min_right);

            }

        }
        static int Find_max(int[] a, int left, int right)
        {
            if (left == right)
            {
                return a[left];
            }
            else
            {
                int mid = (left + right) / 2;
                int Min_left = Find_max(a, left, mid);
                int Min_right = Find_max(a, mid + 1, right);
                return Math.Max(Min_left, Min_right);
            }

        }
    }    
}
