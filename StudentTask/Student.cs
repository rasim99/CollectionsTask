using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTask
{
    internal class Student
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public Dictionary<string,List<int>> Grades { get; private set; }

        public Student(string name, string surName, int age)
        {
            Name = name;
            SurName = surName;
            Age = age;
            Grades = new Dictionary<string,List<int>>();
        }

        public void AddGrade(string subjectName,int grade)
        {
            if (!Grades.ContainsKey(subjectName))
            {
                Grades[subjectName] = new List<int>(); 
            }
            Grades[subjectName].Add(grade);
            Console.WriteLine($"{grade} added to {subjectName}");
        }

        public void RemoveGrade(string subjectName,int grade)
        {
            if (Grades.ContainsKey(subjectName.ToLower()))
            {
                if (Grades[subjectName].Contains(grade))
                {
                    Grades[subjectName].Remove(grade);
                    if (Grades[subjectName].Count == 0)
                    {
                        Grades.Remove(subjectName);
                    }
                    Console.WriteLine($"{grade} removed  from {subjectName}");
                }
                else
                {
                    Console.WriteLine($"{grade} has not in {subjectName}");
                }
            }
            else
            {
                Console.WriteLine($"{subjectName} is not found");
            }
        }
        
        public void RemoveSubject(string subjectName)
        {
            if(Grades.ContainsKey(subjectName))
            {
                Grades.Remove(subjectName);
                Console.WriteLine($"{subjectName} removed");
            }
            else
            {
                Console.WriteLine($"{subjectName} is not found");
            }
        }

        public double GetAvarageGrade(string subjectName)
        {
            if (Grades.ContainsKey(subjectName))
            {
                return Math.Round(Grades[subjectName].Average(),2);
            }
            else Console.WriteLine($"{subjectName}  is not found");
            return 0;
        }

        public void GetAllGradesByStudent()
        {
            Console.WriteLine($"{Name}'s All Avarages");
            foreach (var subject in Grades.Keys)
            {
                Console.WriteLine($"{subject} : {Math.Round(Grades[subject].Average(),2)}");
            }
        }
    }
}
