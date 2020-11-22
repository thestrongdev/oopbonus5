using System;
using System.Collections.Generic;

namespace OopBonus5
{
    class Program
    {
        static void Main(string[] args)
        {

            Student[] test = GetStudent();
            int rankPosition = 0;
            

            foreach (Student student in test)
            {
                rankPosition += 1;
                Console.WriteLine($"{rankPosition}: {student.FirstName}, {student.LastName}, {student.Score}");
            }            
        }

        static Student[] GetStudent()
        {
            List<Student> allStudents = new List<Student>();
            int studentNum = 0;

            Console.WriteLine("Enter the number of students: ");
            string studentCount = Console.ReadLine();
            int.TryParse(studentCount, out int total);

            do
            {
                Student studentInfo = new Student();
                studentNum += 1;

                Console.WriteLine($"Please input student {studentNum} last name");
                string userLastName = Console.ReadLine();
                studentInfo.LastName = userLastName;

                Console.WriteLine($"\nPlease input student {studentNum} first name");
                string userFirstName = Console.ReadLine();
                studentInfo.FirstName = userFirstName;

                Console.WriteLine($"\nPlease input student {studentNum} score");
                string userScore = Console.ReadLine();
                
                if(int.TryParse(userScore, out int score))
                {
                    studentInfo.Score = score;
                }
                else
                {
                    Console.WriteLine("Score must be a whole integer");
                    continue;
                }

                allStudents.Add(studentInfo);

            } while (studentNum<total);

            allStudents.Sort();

            return allStudents.ToArray();

        }
    }
}
