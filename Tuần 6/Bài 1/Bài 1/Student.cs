using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    internal class Student
    {
        private string studentID;
        private string name;
        private int birthYear;
        private bool gender;
        private string stdClass;
        
        public Student() { }
        public Student(string studentID, string name, int birthYear, bool gender, string stdClass)
        {
            this.studentID = studentID;
            this.name = name;
            this.birthYear = birthYear;
            this.gender = gender;
            this.stdClass = stdClass;
        }
        public string Get_StudentID()
        {
            return studentID;
        }
        public void Set_StudentID(string newID)
        {
           
            this.studentID = newID;
        }
        public string Get_Name()
        {
            return name;
        }
        public void Set_Name(string newName)
        {
            this.name = newName;
        }
        public int Get_BirthYear()
        {
            return this.birthYear;
        }
        public void Set_BirthYear(int newbirthYear)
        {
            if (birthYear >= 1900 && birthYear <= DateTime.Now.Year)
            {
                birthYear = newbirthYear;
            }
            else
            {
                Console.WriteLine("Nam khong hop le");
            }         
        }
        public  bool Get_Gender()
        {
            return gender;
        }
        public void Set_Gender(bool newGender)
        {
            gender = newGender;
        }
        public string Get_StdClass()
        {
            return stdClass;
        }
        public void Set_StdClass(string newStdClass)
        {
            stdClass = newStdClass;
        }
        public void Input()
        {
            Console.Write("Nhap ID:");
            studentID = Console.ReadLine();
            Console.Write("Nhap name:");
            name = Console.ReadLine();
            while (true)
            {
                Console.Write($"Nam Sinh:");
                birthYear = int.Parse(Console.ReadLine());
               
                if (birthYear >= 1900 && birthYear <= DateTime.Now.Year)
                {                   
                    break;
                }
                else
                {
                    Console.WriteLine("Nam khong hop le");
                }
            }
            Console.Write("Nhap gioi tinh:");
            gender = bool.Parse(Console.ReadLine());
            Console.Write("Nhap lop:");
            stdClass = Console.ReadLine();
        }
        public int GetAge()
        {
            return DateTime.Now.Year - birthYear;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"ID:{ studentID}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Nam Sinh:{birthYear}");
            if (gender)
            {
                Console.WriteLine("Nam");

            }
            else
            {
                Console.WriteLine("Nu");
            }
            Console.WriteLine($"Lop:{stdClass}");
        }
    }
}
