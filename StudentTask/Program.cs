using System.Text.RegularExpressions;

namespace StudentTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Rasim", "mahmudov", 25);
            while (true)
            {
                DisplayMenu();

                OperationDesc: string input =Console.ReadLine();
                int result;
                bool isSuccessed = int.TryParse(input,out result);
                if (isSuccessed ) 
                {
                    switch (result)
                    {
                        case 0:
                            return;
                        case 1:
                          AddGrade(student);
                        break;
                        case 2:
                            RemoveGrade(student);
                            break;
                        case 3:
                            Console.WriteLine("enter subject name of removed");
                            string subjName=Console.ReadLine();
                            student.RemoveSubject(subjName);
                        break;
                            case 4:
                            Console.WriteLine("enter subject name for displaying avarage grade");
                            string subjectName = Console.ReadLine();

                            Console.WriteLine($"{subjectName} : {student.GetAvarageGrade(subjectName)}");
                                break;
                            case 5:
                            student.GetAllGradesByStudent();
                                break;
                        default:
                            Console.WriteLine("invaild operation please choose correct ");
                            goto OperationDesc;
                    }
                }
                else
                {
                    Console.WriteLine("invalid format! please enter valid format");
                }
              
            }
        }
        static void DisplayMenu()
        {
            Console.WriteLine("___ MENU ____");
            Console.WriteLine(" 1 - AddGrade \n 2 - RemoveGrade \n 3 - RemoveSubject \n 4 - GetAvarageGrade \n " +
                " 5 - GetAllGradesByStudent \n  0 - Exit ");
        }

       static void AddGrade( Student student)
        {
        SubcetNameDesc: Console.WriteLine("enter Subject name ");
            string subjectName = Console.ReadLine();
            if (Regex.IsMatch(subjectName, @"^[a-zA-Z]+$"))
            {
                if (subjectName.Length > 3)
                {
                GradeDesc: Console.WriteLine("enter grade (0-100)");
                   string input = Console.ReadLine();
                    int grade;
                  bool  isSuccessed = int.TryParse(input, out grade);
                    if (isSuccessed && grade >= 0 && grade <= 100)
                    {
                        student.AddGrade(subjectName, grade);
                    }
                    else if (grade > 100)
                    {
                        Console.WriteLine("cannot grade greater than 100");
                        goto GradeDesc;
                    }
                    else if (grade < 0)
                    {
                        Console.WriteLine("cannot negative grade ");
                        goto GradeDesc;
                    }
                    else
                    {
                        Console.WriteLine("Please valid format");
                        goto GradeDesc;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter minimum 4 character");
                    goto SubcetNameDesc;
                }
            }
            else
            {
                Console.WriteLine("Wrong! only letters");
                goto SubcetNameDesc;
            }
        }
        static void RemoveGrade( Student student)
        {
        RemoveSubjectNameDesc: Console.WriteLine("pleaase ! enter  subject name for removed grade");
            string subjectname = Console.ReadLine();
            if (Regex.IsMatch(subjectname, @"^[a-zA-Z]+$"))
            {
            RemoveGradeDesc: Console.WriteLine("pleaase ! enter  grade  for removed");
                string grade = Console.ReadLine();
                int removeGrade;
                bool isSuccessed = int.TryParse(grade, out removeGrade);
                if (isSuccessed)
                {
                    student.RemoveGrade(subjectname.ToLower(), removeGrade);
                }
                else
                {
                    Console.WriteLine("invalid input ! Please valid input");
                    goto RemoveGradeDesc;
                }
            }
            else
            {
                Console.WriteLine(" please enter only letters");
                goto RemoveSubjectNameDesc;
            }
        }
    }
}
