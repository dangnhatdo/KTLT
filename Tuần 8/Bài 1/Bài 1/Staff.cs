using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    internal class Staff:Person
    {
        private string department;
        private double salary;
        public string GetSet_department
        {
            get { return department; }
            set { this.department = value; }
        }
        public double GetSet_salary
        {
            get { return salary; }
            set
            {
                if (value < 0 || value > 1000000)
                {

                    Console.WriteLine("Luong ko hop le!");
                    this.salary = 1;
                }
                else
                {
                    this.salary = value;
                }
            }
        }
        public Staff() { }
        public Staff(string name,int birthYear, string address,string department,double salary) : base(name, birthYear, address)
        {
            this.department = department;
            this.salary = salary;
        }
        public override void Input()//có từ khoá overide để viết đè lên lớp cha
        {
            base.Input();
            Console.WriteLine("Nhap department:");
            this.department= Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Nhap luong:");
                this.salary = int.Parse(Console.ReadLine());
                if (salary > 0 && salary < 1000000)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Luong ko hop le!");
                }
            }
        }
        public override string toString()
        {
            return ($"Staff{base.toString()}-Department:{this.department},Salary:{this.salary}");
        }
        public void UpdateSalary(double salary)
        {
           
            Console.WriteLine("Nhap thay doi salary:");
            this.salary = double.Parse(Console.ReadLine());
        }
    }
}
