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
            Fraction f1=new Fraction(16,5);
            MixedFraction mf1 = new MixedFraction(f1);
            MixedFraction mf2 = new MixedFraction(1, 4, 5);
            Console.WriteLine(mf2.ToString());
            Fraction sum = mf1.Add(mf2);
            MixedFraction sum2 = new MixedFraction(sum);
            Console.WriteLine(sum2);

        }
    }
}
