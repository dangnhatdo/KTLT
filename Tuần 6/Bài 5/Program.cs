using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Author b = new Author("asasas", "123@gmail.com", 'f');
            Book a = new Book("asasas", b, 12000, 100);
            a.toString();
        }
    }
}
