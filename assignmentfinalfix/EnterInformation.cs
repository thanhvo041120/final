using System;
using System.Collections.Generic;
using System.Text;

namespace assignmentfinalfix
{
    class EnterInformation
    {
        public string SetName()
        {
            Console.Write("Name of student is: ");
            string Name = Console.ReadLine();
            return Name;
        }
        public string SetId()
        {
            string ID;
            Console.Write("ID of student is: ");
            ID = Console.ReadLine();
            return ID;
        }
        public List<float> SetGrade()
        {
            float checkGrade;
            List<float> Grades = new List<float>();
            for (var i = 0; i < 2; i++)
            {
                Console.Write("Grade " + (i + 1) + ": ");
                do
                {
                    float grade = float.Parse(Console.ReadLine());
                    checkGrade = CheckGrade(grade);
                } while (checkGrade < 0);
                Grades.Add(checkGrade);
            }
            return Grades;
        }
        public string CheckEnterId(List<Student> students)
        {
            var classes = new Classroom();
            string id;
            do
            {
                id = SetId();
                if (id.Length > 9 || id.Length < 5)
                {
                    Console.WriteLine("Enter again");
                }
                else if (classes.IsIdExist(id,students) == true)
                {
                    Console.WriteLine("ID existed");
                    Console.WriteLine("Enter again");
                }
            } while (id.Length > 9 || id.Length < 5 || classes.IsIdExist(id,students) == true);
            return id;
        }
        public string EnterNumberOfStudent()
        {
            Console.Write("Enter number of students: ");
            string NumberOfStudentWantToAdd = Console.ReadLine();
            return NumberOfStudentWantToAdd;
        }        
        public float CheckGrade(float grade)
        {
            if(grade>10||grade<0)
            {
                Console.WriteLine("Enter again");
                return -1;
            }
            return grade;
        }
        
    }
}
