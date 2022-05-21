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
            Staff b = new Staff();
            b.Input();
            Console.WriteLine(b.toString());
            b.UpdateSalary(1);
            Console.WriteLine(b.toString());
            Student a = new Student();
            a.Input();
            Console.WriteLine(a.toString());
            a.ChangeProgram("P");
            Console.WriteLine(a.toString());


        }
    }
}
