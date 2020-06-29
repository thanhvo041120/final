using System;
using System.Collections.Generic;
using System.Text;

namespace assignmentfinalfix
{
    class UserInterface
    {
        public void MainMenu()
        {
            int i;
            for (i = 1; i <= 40; i++) Console.Write("*");
            Console.Write("\n*         Student of a class           *\n");
            for (i = 1; i <= 40; i++) Console.Write("*");
            Console.Write("\n*\t  Please select the task       *");
            Console.Write("\n*1:Enter a group                       *");
            Console.Write("\n*2:Show information                    *");
            Console.Write("\n*3:Search student by ID                *");
            Console.Write("\n*4:Insert a new student information    *");
            Console.Write("\n*5:Delete a student by ID              *");
            Console.Write("\n*6:Update student by ID                *");
            Console.Write("\n*7:Find students has highest grade     *");
            Console.Write("\n*8:Find students has fail grade        *");
            Console.Write("\n*9:Calculate average grade of student  *");
            Console.Write("\n*0:Exit                                *\n");
            for (i = 1; i <= 40; i++) Console.Write("*");
            Console.Write("\nEnter your choice (0--->8): ");
        }       
        public void HeaderOfTableOfInformation()
        {
            Console.WriteLine("|------------------Show information of Students-------------------|");
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-23}|", "Name", "ID","Grades");
        }
        public void ShowInformationOfAllStudent(List<Student> students)
        {
            HeaderOfTableOfInformation();
            foreach(Student student in students)
            {
                student.ReturnInformationOfAStudent();
            }
        }
        public void ShowInformationOfStudentById(Student student)
        {
            if (student == null) ShowIfNoStudent();
            else
            {
                Console.Clear();
                HeaderOfTableOfInformation();
                student.ReturnInformationOfAStudent();
            }
        }
        public void DeleteOrNot(bool variable)
        {
            if (variable == true) Console.WriteLine("Don't have student");
            else Console.WriteLine("Deleted");
        }
        public void ShowIfNoStudent()
        {
            Console.WriteLine("Don't have student");
        }
        public void ShowStudentsHaveHighestAverageGrade(float highestAverageGrade,List<Student> Students)
        {
            foreach (Student item in Students)
            {
                if (highestAverageGrade == item.CalculateAverageGrade())
                {
                    HeaderOfTableOfInformation();
                    item.ReturnInformationOfAStudent();
                    Console.WriteLine("Hightest average Grade is: " + highestAverageGrade);
                }
            }
        }
        public void ShowStudentsFailed(Student student)
        {
            if(student==null)
            {
                Console.WriteLine("All passed");
            }
            else
            {
                HeaderOfTableOfInformation();
                student.ReturnInformationOfAStudent();
            }
        }
        public void ShowAverageOfEachStudent(List<Student> students)
        {
            foreach(Student item in students)
            {
                HeaderOfTableOfInformation();
                item.ReturnInformationOfAStudent();
                item.CalculateAverageGrade();
                Console.Write("\n");
            }
        }
    }
}
