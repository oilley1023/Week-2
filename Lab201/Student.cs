using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string name;
        private int year;
        private string studentid;
        private bool isactive;
        public Student()
        {
            name = "John Doe";
            studentid = "Unknow";
            Year = 1995;
            isactive = false;
        }
        public Student(string _name, string _id)
        {
            name = _name;
            studentid = _id;
            Year = 1995;
            isactive = true;
        }

        public Student(string _name, string _id, int _yearofbirth)
        {
            name = _name;
            studentid = _id;
            Year = _yearofbirth;
            isactive = true;
        }

        public Student(string _name, string _id, int _yearofbirth, bool _isactive)
        {
            name = _name;
            studentid = _id;
            Year = _yearofbirth;
            isactive = _isactive;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value >= 1950 && value <= 2000)
                {
                    year = value;

                }
                else
                {
                    Console.WriteLine (studentid + " error try setting invalid year - of - birth value!");
                }
            }
        }

        public bool Isactive
        {
            get
            {
                return isactive;
            }
            set
            {
                isactive = value;
                
            }
        }
        public string Studentid
        {
            get
            {
                return studentid;
            }
            set
            {
                studentid = Studentid;
            }
        }
        public int getAge()
        {

            return DateTime.Now.Year -  Year;

        }

        public override string ToString() //Student: s1 (57001), age=20, is active student
        {
            if (Isactive == true)
            {
                return "[Student:" + Name + "(" + Studentid + "), age =" + getAge() + ", is active student";
            }
            else
            {
                return "[Student:" + Name + "(" + Studentid + "), age =" + getAge() + ",is NOT active student";
            }
        }
    }
}


