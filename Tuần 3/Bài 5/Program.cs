using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
           Console.WriteLine(ThuatToan(n));
        }
        static int ThuatToan(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return ThuatToan(n - 1) + ThuatToan(n - 2);
            }
        }
    }
}
