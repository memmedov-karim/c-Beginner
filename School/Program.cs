using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(12, "Karim", "Mammadov", 100, 100, "FRITL");
            student.showStudentInfo();
            student.calculateAvarage();
        }
    }
}
