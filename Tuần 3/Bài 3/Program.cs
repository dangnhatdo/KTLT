using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine(UCLN(a,b));
        }
        static int UCLN (int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            else
            {
                return UCLN(b,a % b);
            }
        }
    }
}
