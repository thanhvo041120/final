using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Diagnostics.Contracts;

namespace assignmentfinalfix
{
    class Classroom
    {
        public List<Student> Students = new List<Student>();
        public int NumberOfStudentActual;
        public void CreateInformationAStudent(string name  , string id, List<float> grades)
        {
            var student = new Student();   
            student.Name = name;
            student.Id = id;
            student.Grades = grades;
            Students.Add(student);
        }
        //case 3
        public Student FindByID(string id)
        {
            Console.Clear();
            if (IsIdExist(id,Students) == false) return null;
            else
            {
                foreach (Student item in Students)
                    if (item.Id == id)
                    {
                        return item;
                    }
            }
            return null;
        }
        public bool IsIdExist(string id,List<Student> students)
        {
            var student = students.SingleOrDefault(s => string.Compare(s.Id, id, true) == 0);
            if (student == null) return false;
            else return true;
        }
        //case5
        public bool DeleteStudentById(string id)
        {
            if (IsIdExist(id, Students) == false)
            {
                return true;
            }
            else
            {
                foreach (Student student in Students)
                {
                    Students.RemoveAll(s => string.Compare(s.Id, id, true) == 0);
                    break;
                }
                return false;
            }
        }
        //case 6
        public Student ChangeNameById(string id,string name,List<float> grades)
        {
            if (IsIdExist(id,Students) == false) return null;
            else
            {
                foreach(Student item in Students)
                {
                    if (item.Id == id)
                    {
                        item.Name = name;
                        item.Grades = grades;
                        return item;
                    }                    
                }
            }
            return null;
        }
        //case 7
        public float FindStudentsHaveHighestAverageGrade()
        {
            float highestGrade;
            List<float> AverageGradeTemp = new List<float>();
            foreach (Student item in Students)
            {
                AverageGradeTemp.Add(item.CalculateAverageGrade());
            }
            AverageGradeTemp.Sort();
            highestGrade = AverageGradeTemp[AverageGradeTemp.Count - 1];
            return highestGrade;
        }
        //case 8
        public Student FindStudentsHaveFailGrade()
        {
            foreach (Student item in Students)
            {
                float AverageGrade = item.CalculateAverageGrade();
                if (AverageGrade < 5)
                {
                    return item;
                }
                else return null;
            }
            return null;
        }
    }
}
