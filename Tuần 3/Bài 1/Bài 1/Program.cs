using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine(GiaiThua(n));
        }
        static int GiaiThua(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n*GiaiThua(n-1);
            }
        }
    }
}
