using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_3
{
    internal class Rectangle
    {
        private double width;
        private double height;
        public double GetSet_Width
        {
            get { return width; }
            set
            {
                if (value >= 0)
                {
                    this.width = value;
                }
                else
                {
                    Console.WriteLine("Chieu rong khong hop le");
                    this.width = 1;
                }
            }
        }
        public double GetSet_height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                {
                    this.height = value;
                }
                else
                {
                    Console.WriteLine("Chieu dai khong hop le");
                    this.height = 2;
                }
            }
        }
        public Rectangle()
        {
            this.width = 1;
            this.height = 2;
        }
        public Rectangle(double width, double height)
        {
            this.width= width;
            this.height= height;
        }
        public void Input()
        {
            while (true)
            {
                Console.WriteLine("Nhap chieu dai:");
                this.height=double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap chieu rong:");
                this.width=double.Parse(Console.ReadLine());
                if(this.width > 0 && this.height > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Du lieu khong hop le!");
                }
            }
        }
        public void toString()
        {
            Console.WriteLine($"Chieu dai:{this.height} va chieu rong:{this.width}");
        }
        public double GetPerimeter()
        {
            double c = (this.width + this.height) * 2;
            return c;
        }
        public double GetArea()
        {
            double c= this.width * this.height;
            return c;
        }
        public bool IsSameArea(Rectangle a)
        {
            if (a.GetArea() == this.GetArea())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
