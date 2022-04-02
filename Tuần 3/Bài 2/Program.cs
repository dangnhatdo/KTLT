using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());
            int n=int.Parse(Console.ReadLine());    
            LuyThua(a, n);
        }
        static int LuyThua(int a, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n % 2 == 0)
            {
                return LuyThua(a, n / 2) * LuyThua(a, n / 2);
            }
            else
            {
                return a * LuyThua(a, (n - 1) / 2) * LuyThua(a, (n - 1) / 2);
            }
        }
    }
}
