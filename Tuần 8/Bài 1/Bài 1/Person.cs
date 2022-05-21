using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    internal class Person
    {
        private string name;
        private int birthYear;
        private string address;
        public string GetSet_name
        {
            get { return name; }
            set { name = value; }
        }
        public int GetSet_birthYear
        {
            get { return birthYear; }
            set
            {
                if (value < 1900 || value > 9999)
                {
                    this.birthYear = 1900;
                }
                else
                {
                    this.birthYear = value;
                }
            }
        }  
        public string GetSet_address
        {
            get { return address; }
            set
            {
                this.address = value;
            }
        }
        public Person() { }
        public Person(string name,int birthYear,string address)
        {
            this.name = name;
            this.birthYear = birthYear;
            this.address = address;
        }
        public virtual void Input()// có từ khoá virtual để lớp con có thể viết đè lên 
        {
            Console.WriteLine("Nhap name:");
            this.name = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Nhap nam sinh:");
                this.birthYear = int.Parse(Console.ReadLine());
                if (birthYear > 1900 && birthYear < 9999)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nam sinh ko hop le!");
                }
            }
            Console.WriteLine("Nhap address:");
            this.address = Console.ReadLine();
        }
        public int GetAge()
        {
            return DateTime.Now.Year - this.birthYear;
        }
        public virtual string toString()
        {
            return ($"Person[Name:{this.name},Age: {this.birthYear},Address: {address}]");
        }
    }
}
