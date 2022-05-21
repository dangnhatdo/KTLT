using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    internal class Student:Person
    {
        private string program;
        private int year;
        public string GetSet_program
        {
            get { return program; }
            set { this.program = value; }
        }
        public int GetSet_year
        {
            get { return year; }
            set
            {
                if (value < 0 && value > 10)
                {
                    this.year = 1;
                }
                else
                {
                    this.year = value;
                }
            }
        }
        public Student() { }
        public Student(string name, int birthYear, string address, string program, int year) : base(name, birthYear, address)
        {
            this.program = program;
            this.year = year;
        }
        public override void Input()//có từ khoá overide để viết đè lên lớp cha
        {
            base.Input();
            Console.WriteLine("Nhap program:");
            this.program = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Nhap year:");
                this.year = int.Parse(Console.ReadLine());
                if (year > 0 && year < 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nam hoc ko hop le!");
                }
            }
        }
        public override string toString()
        {
            return ($"Student{base.toString()}-Program:{this.program},Year:{this.year}");
        }
        public void ChangeProgram(string program)
        {
            Console.WriteLine("Nhap thay doi progaram:");
            this.program=Console.ReadLine();
        }
    }
}
