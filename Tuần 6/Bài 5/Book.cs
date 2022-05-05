using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_5
{
    internal class Book
    {
        private string name;
        private Author author;
        private double price;
        private int qty;
        public Book(string name, Author author, double price, int qty)
        {
            this.Name = name;
            this.author = author;
            this.Price = price;
            this.Qty = qty;
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }
        public int Qty
        {
            get { return qty; }
            set
            {
                qty = value;
            }
        }
        public Author Author
        {
            get { return author; }
        }
        public void toString()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write($"Book[Tên:{this.name},Giá:{this.price},Trọng lượng:{ this.qty}/ ");
            author.toString();
        }
    }
}
