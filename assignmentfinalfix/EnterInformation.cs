using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            float resultOfCheckGrade;
            string grades;
            
            List<float> Grades = new List<float>();
            for (var i = 0; i < 2; i++)
            {
                Console.Write("Grade " + (i + 1) + ": ");
                do
                {
                    grades = Console.ReadLine();
                    resultOfCheckGrade = CheckGrade(grades);
                } while (resultOfCheckGrade < 0);
                Grades.Add(resultOfCheckGrade);
            }
            return Grades;
        }
        public string CheckEnterId(List<Student>Students)
        {
            Student student;
            string id;
            do
            {
                id = SetId();
                student = Students.SingleOrDefault(s => string.Compare(s.Id, id, true) == 0);
                if (id.Length > 9 || id.Length < 5)
                {
                    Console.WriteLine("Enter again");
                }
                else if (student != null)
                {
                    Console.WriteLine("ID existed");
                    Console.WriteLine("Enter again");
                }
            } while (id.Length > 9 || id.Length < 5 || student != null);
            return id;
        }
        public string EnterNumberOfStudent()
        {
            Console.Write("Enter number of students (0--->150): ");
            string numberOfStudentWantToAdd = Console.ReadLine();
            return numberOfStudentWantToAdd;
        }  
        public string CheckNumberOfStudent()
        {
            string numberOfStudentWantToAdd;
            do
            {
                numberOfStudentWantToAdd = EnterNumberOfStudent();
                if(numberOfStudentWantToAdd.Length >= 3)
                {
                    Console.WriteLine("Invalid input");
                }
            } while (numberOfStudentWantToAdd.Length >= 3);
            return numberOfStudentWantToAdd;
        }
        public float CheckGrade(string grades)
        {
            bool isGradeCorrect;
            float grade;
            isGradeCorrect = float.TryParse(grades, out grade);
            if (isGradeCorrect==false)
            {
                Console.WriteLine("Enter again");
                return -1;
            }
            else if (grade>10||grade<0)
                 {
                     Console.WriteLine("Enter again");
                     return -1;
                 }
            return grade;
        }
        public string CheckNameEntered()
        {
            string nameThatWantToCheck;
            do
            {
                nameThatWantToCheck = SetName();
            } while (nameThatWantToCheck == "");
            return nameThatWantToCheck;
        }
        public string CheckIdEntered()
        {
            string idThatWantToCheck;
            do
            {
                idThatWantToCheck = SetId();
            } while (idThatWantToCheck == "");
            return idThatWantToCheck;
        }
    }
}
