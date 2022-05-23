using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    internal class ConNguoi
    {
        private string hoten;
        private int namsinh;
        private string diachi;
        public ConNguoi() { }
        public ConNguoi(string hoten, int namsinh, string diachi)
        {
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.diachi = diachi;
        }
        public string Hoten
        {
            get { return hoten; }
            set
            {
                this.hoten = value;
            }
        }
        public int Namsinh
        {
            get { return namsinh; }
            set
            {
                this.namsinh = value;
            }
        }
        public string Diachi
        {
            get { return diachi; }
            set
            {
                this.diachi = value;
            }
        }
        public virtual void InPut()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Mời nhập họ và tên: ");
            this.hoten = Console.ReadLine();
            Console.Write("Mời nhập năm sinh: ");
            this.namsinh = int.Parse(Console.ReadLine());
            Console.Write("Mời nhập địa chỉ: ");
            this.diachi = Console.ReadLine();
        }

        public override string ToString()
        {
            return ($"ThongTin: {hoten}, {namsinh}, {diachi}");
        }
    }
}
