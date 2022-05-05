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
            Rectangle a = new Rectangle();
            Rectangle b = new Rectangle();
            a.Input();
            b.Input();
            a.toString();
            b.toString();
            Console.WriteLine($"Chu vi hinh chu nhat 1 la:{a.GetPerimeter()}");
            Console.WriteLine($"Dien tich hinh chu nhat 2 la:{b.GetArea()}");
            if (b.IsSameArea(a))
            {
                Console.WriteLine("Dien tich 2 hinh chu nhat bang nhau");
            }
            else
            {
                Console.WriteLine("Dien tich 2 hinh chu nhat khong bang nhau");
            }
        }
    }
}
