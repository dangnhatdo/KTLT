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
            Fraction a = new Fraction();
            a.Input();
            Fraction b = new Fraction();
            b.Input();
            a.Add(b);
            a.Subtract(b);
            a.Multiply(b);
            a.Divide(b);

        }
    }
}
