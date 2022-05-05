using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_4
{
    internal class Date
    {
        private int day;
        private int month;
        private int year;
        public int GetSet_day
        {
            get{return day;}
            set
            {
                if (value < 1 || value > 31)
                {
                    Console.WriteLine("Ngay khong hop le");
                    this.day = 1;
                }
                else
                {
                    this.day = value;
                }
            }
        }
        public int GetSet_month
        {
            get{return month;}
            set
            {
                if(month < 1 || month > 12)
                {
                    Console.WriteLine("Thang khong hop le");
                    this.month = 1;
                }
                else
                {
                    this.month=value;
                }
            }
        }
        public int GetSet_year
        {
            get{return year;}
            set
            {
                if(year < 1900 || year > 9999)
                {
                    Console.WriteLine("Nam khong hop le");
                    this.year = 1900;
                }
                else
                {
                    this.year=value;
                }
            }
        }
        public Date()
        {
            this.day = 1;
            this.month = 1;
            this.year = 1900;
            toString();
        }
        public Date(int day,int month,int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            toString();
        }
        public void setDate(int d, int m, int y)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (d > 31 || d < 1)
            {
                Console.WriteLine("Ngày không hợp lệ!");
                this.day = 1;
            }
            else
                day = d;
            if (m > 12 || m < 1)
            {
                Console.WriteLine("Tháng không hợp lệ!");
                month = 1;
            }
            else
                month = m;
            if (y > 9999 || y < 1900)
            {
                Console.WriteLine("Năm không hợp lệ!");
                year = 1900;
            }
            else
                year = y;
            toString(); 
        }
        public void toString()
        {
            Console.WriteLine($"{this.day:D2}/{this.month:D2}/{this.year:D4}");
        }
    }
}
