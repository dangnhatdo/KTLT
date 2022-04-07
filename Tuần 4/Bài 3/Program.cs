using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char dau = 'A';
            char giua = 'B';
            char cuoi = 'C';
            ThapHaNoi(n, dau, giua, cuoi);
        }
        static void ThapHaNoi(int n, char dau, char giua, char cuoi)
        {
            if (n == 1)
            {
                Console.WriteLine($"Chuyen 1 dia tu cot {dau} -> {cuoi}");
            }
            else
            {
                ThapHaNoi(n - 1, dau, cuoi,giua);
                ThapHaNoi(1, dau, giua, cuoi);
                ThapHaNoi(n - 1, giua, dau, cuoi);
            }
        }

    }
}
