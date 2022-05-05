using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{

    internal class Fraction
    {
        private int numerator;
        private int denominator;
        public int GetSet_numerator
        {
            get { return numerator; }
            set { this.numerator = value; }
        }
        public int GetSet_denominator
        {
            get { return denominator; }
            set
            {
                if (denominator == 0)
                {
                    this.denominator = 1;
                }
                else
                {
                    this.denominator = value;
                }
            }
        }
        //constructer phân số =0
        public Fraction()
        {
            this.numerator = 0;
            this.denominator = 1;
        }
        //constructer có tham số
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            Simplify();
        }
        //constructer phân số có mẫu =1
        public Fraction(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
        }
        public int UCLN(int a, int b)
        {
            int r = a % b;
            if (r == 0)
            {
                return b;
            }
            else
            {
                return UCLN(b, r);
            }
        }
        //Tối giản
        private void Simplify()
        {
            int ketqua = UCLN(this.numerator, this.denominator);
            this.numerator /= ketqua;
            this.denominator /= ketqua;
            toString();
        }
        public void Input()
        {
            Console.WriteLine("Moi nhap tu so:");
            this.numerator = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Moi nhap mau so:");
                this.denominator = int.Parse(Console.ReadLine());
                if (denominator != 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Mau so khong hop le");
                    Console.WriteLine("Moi nhap mau so:");
                    this.denominator = int.Parse(Console.ReadLine());
                }
            }

        }
        public double Decimal()
        {
            return this.numerator * 1.0 / this.denominator;
        }
        public Fraction Add(Fraction p)
        {
            int x = numerator * p.denominator + p.numerator * denominator;
            int y = denominator * p.denominator;
            Fraction c = new Fraction(x, y);
            return c;
        }
        public Fraction Subtract(Fraction p)
        {
            int x = numerator * p.denominator - p.numerator * denominator;
            int y = denominator * p.denominator;
            Fraction c = new Fraction(x, y);
            return c;
        }
        public Fraction Multiply(Fraction p)
        {
            int x = numerator * p.numerator;
            int y = denominator * p.denominator;
            Fraction c = new Fraction(x, y);
            return c;
        }
        public Fraction Divide(Fraction p)
        {
            int temp = p.numerator;
            p.numerator = p.denominator;
            p.denominator = temp;
            int x = this.numerator * p.numerator;
            int y = this.denominator * p.denominator;
            Fraction c = new Fraction(x, y);
            return c;

        }
        public void toString()
        {
            if (this.denominator < 0)//chuyển dấu trừ lên tử số
            {
                this.numerator = -this.numerator;
                this.denominator = -this.denominator;
            }
            Console.WriteLine($"{this.numerator}/{this.denominator}");
        }
    }
}
