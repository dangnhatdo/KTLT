using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    internal class SinhVien:ConNguoi
    {
        private string maSV;
        private double diemToan;
        private double diemLy;
        private double diemHoa;
        private double dtb;
        public SinhVien() { }
        public SinhVien(string hoten, int namsinh, string diachi, string maSV, double diemToan, double diemLy, double diemHoa) : base(hoten, namsinh, diachi) 
        {
            this.maSV = maSV;
            this.diemToan = diemToan;
            this.diemLy = diemLy;
            this.diemHoa = diemHoa;
        }
        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        public double DiemToan
        {
            get { return diemToan; }
            set { diemToan = value; }
        }
        public double DiemLy
        {
            get { return diemLy; }
            set { diemLy = value; }
        }
        public double DiemHoa
        {
            get { return diemHoa; }
            set { diemHoa = value; }
        }
        public double Dtb { get { return dtb; } }
        public void DTB()
        {

            if (diemToan <= 0 && diemLy <= 0 && diemHoa <= 0)
            {
                Console.WriteLine("Fail");

            }
            else
            {
                dtb = (diemToan + diemLy + diemHoa) * 1.0 / 3;
                Console.WriteLine("DTB: " + dtb);
            }           
        }
        private void swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
        public void SapXep()
        {
            if (diemToan > diemLy)
            {
                swap(ref diemToan, ref diemLy); 
            }
            if (diemLy > diemHoa)
            {
                swap(ref diemLy, ref diemHoa);
            }
            if (diemToan > diemHoa)
            {
                swap(ref diemToan, ref diemHoa);
            }
            Console.WriteLine($"Thứ tự tăng dần của điểm các môn: {diemToan}, {diemLy}, {diemHoa}");
        }
        public override void InPut()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            base.InPut();
            Console.Write("Mời nhập Mã SV: ");
            maSV = Console.ReadLine();
            Console.Write("Mời nhập điểm Toán: ");
            diemToan = double.Parse(Console.ReadLine());
            Console.Write("Mời nhập điểm Lý: ");
            diemLy = double.Parse(Console.ReadLine());
            Console.Write("Mời nhập điểm Hóa: ");
            diemHoa = double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return ($" Sinh Viên [{base.ToString()},{maSV},{diemToan},{diemLy},{diemHoa}],{dtb}");
        }
    }
}
