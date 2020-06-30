using System;
using System.Collections.Generic;
using System.Text;

namespace assignmentfinalfix
{
    class Application
    {
        public void Active()
        {
            Classroom Classes = new Classroom();
            UserInterface UI = new UserInterface();
            char askToContinue;
            var enter = new EnterInformation();
            int optionItem;
            int isStudentExist;
            string userInput;
            do
            {
                UI.MainMenu();
                do
                {
                    userInput = Console.ReadLine();
                    optionItem = CheckAndReturn(userInput);
                } while (optionItem == -1);
                switch (optionItem)
                {
                    case 1:
                        Console.Clear();
                        string numberOfStudents;
                        int numberOfStudent;
                        bool isTrueOrFalse;
                        do
                        {
                            Console.Clear();
                            numberOfStudents = enter.EnterNumberOfStudent();
                            isTrueOrFalse = int.TryParse(numberOfStudents, out numberOfStudent);
                        } while (isTrueOrFalse == false);
                        Classes.NumberOfStudentActual = numberOfStudent + Classes.Students.Count;
                        for (var i = Classes.Students.Count; i < Classes.NumberOfStudentActual; i++)
                        {
                            Console.Clear();
                            Classes.CreateInformationAStudent(enter.SetName(), enter.CheckEnterId(Classes.Students), enter.SetGrade());
                        }
                        break;
                    case 2:
                        Console.Clear();
                        isStudentExist = Classes.CheckStudentExist();
                        if (isStudentExist == 0)
                        {
                            UI.ShowIfNoStudent();
                            break;
                        }
                        else UI.ShowInformationOfAllStudent(Classes.Students);
                        break;
                    case 3:
                        Console.Clear();
                        isStudentExist = Classes.CheckStudentExist();
                        if (isStudentExist == 0)
                        {
                            UI.ShowIfNoStudent();
                            break;
                        }
                        else UI.ShowInformationOfStudentById(Classes.FindStudentByID(enter.SetId()));
                        break;
                    case 4:
                        Console.Clear();                        
                        Classes.CreateInformationAStudent(enter.SetName(), enter.CheckEnterId(Classes.Students),enter.SetGrade());                           
                        break;
                    case 5:
                        Console.Clear();
                        isStudentExist = Classes.CheckStudentExist();
                        if (isStudentExist == 0)
                        {
                            UI.ShowIfNoStudent();
                            break;
                        }
                        else UI.DeleteOrNot(Classes.DeleteStudentById(enter.SetId()));
                        break;
                    case 6:
                        Console.Clear();
                        isStudentExist = Classes.CheckStudentExist();
                        if (isStudentExist == 0)
                        {
                            UI.ShowIfNoStudent();
                            break;
                        }
                        else UI.ShowInformationOfStudentById(Classes.ChangeInformationOfAStudentById(enter.SetId(),enter.SetName(),enter.SetGrade()));
                        break;
                    case 7:
                        Console.Clear();
                        isStudentExist = Classes.CheckStudentExist();
                        if (isStudentExist == 0)
                        {
                            UI.ShowIfNoStudent();
                            break;
                        }
                        else UI.ShowStudentsHaveHighestAverageGrade(Classes.FindHighestAverageGrade(), Classes.Students);
                        break;
                    case 8:
                        Console.Clear();
                        isStudentExist = Classes.CheckStudentExist();
                        if (isStudentExist == 0)
                        {
                            UI.ShowIfNoStudent();
                            break;
                        }
                        else UI.ShowStudentsFailed(Classes.FindStudentsHaveFailGrade());
                        break;
                    case 9:
                        Console.Clear();
                        isStudentExist = Classes.CheckStudentExist();
                        if (isStudentExist == 0)
                        {
                            UI.ShowIfNoStudent();
                            break;
                        }
                        else UI.ShowAverageOfEachStudent(Classes.Students);
                        break;
                    case 0: Console.Clear(); Console.Write("DONE"); break;
                    default: Console.Clear(); Console.WriteLine("ERROR"); break;
                }
                askToContinue = CheckToContinue(optionItem);
            } while (optionItem != 0 && askToContinue == 'y');
        }
        public int CheckAndReturn(string Variable)
        {
            int resultOfChecking;
            var UI = new UserInterface();
            bool isInputValid;
            isInputValid = int.TryParse(Variable, out resultOfChecking);
            if (isInputValid == true)
                return resultOfChecking;
            else
            {
                Console.WriteLine("Enter again");
                return -1;
            }
        }
        public char CheckToContinue(int optionItem)
        {
            char choiceToContinue = 'y';
            if (optionItem != 0)
            {
                Console.Write("Finish\nDo you want to continue?[y/n]");
                choiceToContinue = char.Parse(Console.ReadLine());
                if (choiceToContinue == 'n')
                {
                    Console.Clear();
                    Console.Write("DONE");
                    return choiceToContinue;
                }
                else
                {
                    Console.Clear();
                    return choiceToContinue;
                }
            }
            return choiceToContinue;
        }        
    }
}

         
                