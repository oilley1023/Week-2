using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        private string name;
        private string courseID;
        private string lecturer;
        private int maxStudents;
        private int numStudents;

        public Course ()
        {
            name = "patsamon";
            courseID = "ENG201";
            lecturer = "staff";
            maxStudents = 30;
            numStudents = 0;
        }
        public Course(string _name, string _Courseid)
        {
            name = _name;
            courseID = _Courseid;
            lecturer = "staff";
            maxStudents = 30;
            numStudents = 0;
        }
        public Course(string _name ,string _Courseid,string _Lecturer)
        {
            name = _name;
            courseID = _Courseid;
            lecturer = _Lecturer;
            maxStudents = 30;
            numStudents = 0;
        }
        public Course(string _name, string _Courseid, string _Lecturer,int _Maxstudent)
        {
            name = _name;
            courseID = _Courseid;
            lecturer = _Lecturer;
            maxStudents = _Maxstudent;
            numStudents = 0;
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

        public string CourseID
        {
            get
            {
                return courseID;
            }

            set
            {
                if (value.Length == 6)
                {
                    int temp = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (char.IsDigit(value[i]))
                        {
                            temp++;
                        }
                    }
                    if (temp == 6)
                    {
                        courseID = value;
                    }
                    else
                    {
                        Console.WriteLine(courseID + ": error try setting invalid CourseID!");
                    }

                } else
                {
                    Console.WriteLine(courseID + ": error try setting invalid CourseID!");
                }
            }
        }

        public string Lecturer
        {
            get
            {
                return lecturer;
            }

            set
            {
                lecturer = value;
            }
        }


        public int MaxStudents
        {
            get
            {
                return maxStudents;
            }

            set
             { if (value < numStudents || value > 80 || value < 0)
                 {
                    Console.WriteLine(courseID + " error try setting invalid Max No. Students!");
                 }
                 else
                 {
                      maxStudents = value;
                 }
             }
         }
         

          

        public int NumStudents
        {
            get
            {
                return numStudents;
            }

            set

           
            { if (value > maxStudents || value < 0)
                 {
                     Console.WriteLine(courseID + ": error try setting invalid No. Students!");

                 }
             else
                 {
                   numStudents = value;  
                 }

             }
        }
        public override string ToString() 
            // [Course: Object-Oriented Programming (261200), Lecturer=staff, has 0 students, max=30]
        {
            
            
                return "[Course :"+name+"("+ courseID +"),Lecturer ="+ lecturer +",has"+ numStudents+"students,max ="+ maxStudents + "]";


        }
    }

}
