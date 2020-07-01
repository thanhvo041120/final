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
                        string numberOfStudentToString;
                        uint numberOfStudent;
                        uint numberStudentInList = uint.Parse(Classes.Students.Count.ToString());
                        bool isTrueOrFalse;
                        do
                        {
                            Console.Clear();
                            numberOfStudentToString = enter.CheckNumberOfStudent();
                            isTrueOrFalse = uint.TryParse(numberOfStudentToString, out numberOfStudent);
                        } while (isTrueOrFalse == false);
                        uint numberOfStudentActual = numberOfStudent + numberStudentInList;
                        for (var i = numberStudentInList; i < numberOfStudentActual; i++)
                        {
                            Console.Clear();
                            Classes.CreateInformationAStudent(enter.CheckNameEntered(), enter.CheckEnterId(Classes.Students), enter.SetGrade());
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
                        else UI.ShowInformationOfStudentById(Classes.FindStudentByID(enter.CheckIdEntered()));
                        break;
                    case 4:
                        Console.Clear();                        
                        Classes.CreateInformationAStudent(enter.CheckNameEntered(), enter.CheckEnterId(Classes.Students),enter.SetGrade());                           
                        break;
                    case 5:
                        Console.Clear();
                        isStudentExist = Classes.CheckStudentExist();
                        if (isStudentExist == 0)
                        {
                            UI.ShowIfNoStudent();
                            break;
                        }
                        else UI.DeletedOrNot(Classes.DeleteStudentById(enter.CheckIdEntered()));
                        break;
                    case 6:
                        Console.Clear();
                        isStudentExist = Classes.CheckStudentExist();
                        if (isStudentExist == 0)
                        {
                            UI.ShowIfNoStudent();
                            break;
                        }
                        else UI.ShowInformationOfStudentById(Classes.ChangeInformationOfAStudentById(enter.CheckIdEntered(), enter.CheckNameEntered(), enter.SetGrade()));
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
        public int CheckAndReturn(string inputOfUser)
        {
            int resultOfChecking;
            var UI = new UserInterface();
            bool isInputValid;
            isInputValid = int.TryParse(inputOfUser, out resultOfChecking);
            if (isInputValid == true)
            {
                if (resultOfChecking < 0)
                {
                    Console.Write("Enter again: ");
                    return -1;
                }
                else return resultOfChecking;
            }
            else
            {
                Console.Write("Enter again: ");
                return -1;
            }           
           
        }
        public char CheckToContinue(int optionItem)
        {
            char choiceToContinue = 'y';
            if (optionItem != 0)
            {
                Console.Write("Finish\nDo you want to continue?[y/n]: ");
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

         
                