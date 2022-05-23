using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    internal class Program
    {
        static void Sort(List<double> List_DIEM)
        {
            //Interchange Sort
            for (int i = 0; i < List_DIEM.Count - 1; i++)
            {
                for (int j = i + 1; j < List_DIEM.Count; j++)
                {
                    if (List_DIEM[i] < List_DIEM[j])
                    {
                        double temp = List_DIEM[i];
                        List_DIEM[i] = List_DIEM[j];
                        List_DIEM[j] = temp;
                    }
                }
            }
        }
        static double Min_DTB(List<double> List_DIEM)
        {
            double min = double.MaxValue;//Max in List_DIEM
            for (int i = 0; i < List_DIEM.Count; i++)
            {
                if (List_DIEM[i] < min)
                {
                    min = List_DIEM[i];
                }
            }
            return min;
        }
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //SinhVien a = new SinhVien();
            //a.InPut();
            //a.SapXep();
            //a.DTB();
            List<SinhVien> dssv = new List<SinhVien>();
            List<double> diem = new List<double>();
            Console.Write("Mời nhập số lượng sinh viên: ");
            int n = int.Parse(Console.ReadLine());           
            for (int i = 0; i < n; i++)
            {
                SinhVien sinhVien = new SinhVien();
                sinhVien.InPut();
                sinhVien.DTB();
                dssv.Add(sinhVien);              
                diem.Add(sinhVien.Dtb);
            }
            Sort(diem);//sắp xếp điểm trung bình trong danh sách "diem" đã được thêm dữ liệu vào
            //vòng lặp
            foreach (double value in diem)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"DTB thấp nhất: {Min_DTB(diem)}");

        }
    }
}
