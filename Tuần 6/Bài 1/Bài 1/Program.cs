using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student a=new Student();
            a.Input();           
            Console.WriteLine(a.GetAge());
            a.PrintInfo();
            
        }
    }
}
