using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student
    {
        private int studentNo;
        private string Name;
        private string Surname;
        private int Viz1;
        private int Viz2;
        private string School;

        public Student(int _studentNo, string _Name, string _Surname, int _Viz1, int _Viz2, string _School)
        {
            studentNo = _studentNo;
            Name = _Name;
            Surname = _Surname;
            Viz1 = _Viz1;
            Viz2 = _Viz2;
            School = _School;
           
        }

        public void showStudentInfo()
        {
            Console.WriteLine($"No:{studentNo}\nName:{Name}\nSurname:{Surname}\nViz1:{Viz1}\nViz2:{Viz2}\nSchool:{School}");
        }
        public void calculateAvarage()
        {
            if ((Viz1 + Viz2) % 2 == 0)
            {
                int av = (Viz2 + Viz1) / 2;
                Console.WriteLine($"Avarage:{av}");
            }
            else
            {
                Console.WriteLine($"Avarage:{(double)(Viz1 + Viz2) / 2}");
            }
        }
    }
}
