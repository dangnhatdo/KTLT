using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(DaoNguoc(Bin_Dec(n)));
        }
        static string Bin_Dec(int n)//Hàm cập nhập giá trị cho chuỗi s1 theo dạng số thập phân ngược
        {
            string s1 = "";
            if (n == 0)
            {
                return s1;
            }
            else if (n == 1)
            {
                n = 0;
                s1 += '1';
                return s1 + Bin_Dec(n);
            }
            else
            {
                if (n % 2 == 0)
                {
                    s1 += '0';
                    n = n / 2;
                    return s1 + Bin_Dec(n);
                }
                else
                {
                    s1 += '1';
                    n = n / 2;
                    return s1 + Bin_Dec(n);
                }
            }
        }
        static string DaoNguoc(string s1)//Hàm in ra kết quả ngược lại s1
        {
            string s2 = "";
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                s2 += s1[i];
            }
            return s2;
        }
    }
}
