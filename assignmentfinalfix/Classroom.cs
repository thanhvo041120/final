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
        public void CreateInformationAStudent(string name  , string id, List<float> grades)
        {
            var student = new Student();   
            student.Name = name;
            student.Id = id;
            student.Grades = grades;
            Students.Add(student);
        }
        //case 3
        public Student FindStudentByID(string id)
        {
            Console.Clear();
            if (IsIdExist(id) == false) return null;
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
        public bool IsIdExist(string id)
        {
            var student = Students.SingleOrDefault(s => string.Compare(s.Id, id, true) == 0);
            if (student == null) return false;
            else return true;
        }
        //case5
        public bool DeleteStudentById(string id)
        {
            if (IsIdExist(id) == false)
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
        public Student ChangeInformationOfAStudentById(string id,string name,List<float> grades)
        {
            if (IsIdExist(id) == false) return null;
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
        public float FindHighestAverageGrade()
        {
            float highestGrade;
            List<float> AverageGradeContain = new List<float>();
            foreach (Student item in Students)
            {
                AverageGradeContain.Add(item.CalculateAverageGrade());
            }
            AverageGradeContain.Sort();
            highestGrade = AverageGradeContain[AverageGradeContain.Count - 1];
            return highestGrade;
        }
        //case 8
        public List<Student> FindStudentsHaveFailGrade()
        {
            List<Student> studentsfailed = new List<Student>();
            foreach (Student item in Students)
            {
                float averageGrade = item.CalculateAverageGrade();
                if (averageGrade < 5)
                {
                    studentsfailed.Add(item);
                    return studentsfailed;
                }
                else return null;
            }
            return null;
        }
        public int CheckStudentExist()
        {
            int isStudentExist = Students.Count;
            if (isStudentExist == 0)
            {
                return 0;
            }
            else return isStudentExist;
        }
    }
}
