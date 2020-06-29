using System;
using System.Collections.Generic;
using System.Text;

namespace assignmentfinalfix
{
    class Student
    {

        public string Name;
        public string Id;
        public List<float> Grades = new List<float>();
        public float CalculateAverageGrade()
        {
            float averageGrade;
            float sum = 0;
            foreach (float item in Grades)
            {
                sum += item;
            }
            averageGrade = sum / Grades.Count;
            return averageGrade;
        }

        public void ReturnInformationOfAStudent()
        {
            Console.Write("|{0,-20}|{1,-20}|", Name, Id);
            foreach (float grade in Grades)
            {
                Console.Write("Grade: {0,-5}", grade);
            }
            Console.Write("{0}\n","|");
        }
    }
}
