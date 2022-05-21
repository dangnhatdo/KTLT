using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bài_2
{
    internal class MixedFraction:Fraction
    {
        public MixedFraction(int wholePart, int numerator, int denominator) : base(wholePart*denominator+numerator, denominator)
        {
        }
        public MixedFraction(Fraction f) : base(f)
        {
        }      
        public override string ToString()
        {
            int whole = numerator / denominator;//chia lấy nguyên
            int num = numerator % denominator;//chia lấy dư
            return ($"{whole}[{num}/{denominator}]");
        }   
    }
}
