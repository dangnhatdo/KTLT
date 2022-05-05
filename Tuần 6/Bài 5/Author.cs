using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_5
{
    internal class Author
    {
        private string name;
        private string email;
        private char gender;
        public string GetSet_name
        {
            get { return name; }
        }
        public string GetSet_email
        {
            get { return email; }
            set
            {
                this.email = value;
            }
        }
        public char GetSet_gender
        {
            get { return gender; }
            set
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                if (value != 'm' || value != 'f')
                {
                    Console.WriteLine("Không hợp lệ!");
                    this.gender = 'm';
                }
                else
                    this.gender = value;
            }
        }
        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }
        public void toString()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (this.gender == 'm')
            {
                Console.WriteLine($"Tác giả[{this.name},{this.email},Nam]");
            }
            else if (this.gender == 'f')
            {
                Console.WriteLine($"Tác giả[{this.name},{this.email},Nữ]");
            }
        }
    }
}

