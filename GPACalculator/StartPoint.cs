using System;
using System.Collections.Generic;
namespace GPACalculator
{
    internal class StartPoint
    {
        public void Start()
        {
            Validation validation = new Validation();
            Student student = new Student();
            PrintTable print = new PrintTable();
            Console.WriteLine("\n\n\t\t\t<<<<<<<< GPA CALCULATOR >>>>>>>>");
            while (true)
            {
                
                //USER ENTER COURSE NAME & COURSE CODE, COURSE UNIT AND SCORE
                Console.Write("\nEnter Course Code : ");
                String courseCode = Console.ReadLine();
                string validatedCourseCode = validation.CourseCode(courseCode);
                Console.Write("\nEnter Course Unit : ");
                String courseUnit = Console.ReadLine();
                string validatedCourseUnit = validation.ValidateCourseUnit(courseUnit);
                Console.Write("\nEnter Score : ");
                String score = Console.ReadLine();
                string validatedScore = validation.ValidateGradeUnit(score);
                //CREATE A COURSE OBJECT AND SAVE USER INPUT 
                Courses course = new Courses();
                course.Calculate(validatedCourseCode, validatedCourseUnit, validatedScore);

                //STORE ALL COURSES INTO A DICTIONARY IN THE STUDENT OBJECT 
                student.CoursesDictionary.Add(validatedCourseCode, course);
                print.Table(student);

                Console.Write("\n\t\tType \"1\" to add courses or \" 2\" to calucalte GPA:");
                string command = Console.ReadLine();
                if (command.ToLower() == "2")
                {
                    
                    break;
                }
               
                student.GPACalculator();
                Console.WriteLine("\n\n\t\tTotal Course Unit Registered: " + student.TotalCourseUnitRegistered);
                Console.WriteLine("\n\t\tTotal Course Unit Passed:     " + student.TotalCourseUnitPassed);
                Console.WriteLine("\n\t\tTotal Course Weight Point:    " + student.TotalWeightPoint);
                Console.WriteLine("\n\t\tGPA:                          " + student.GPA);
                Console.Clear();
                
            }
            Console.Clear();
            print.Table(student);
            student.GPACalculator();
            Console.WriteLine("\n\n\t\tTotal Course Unit Registered: " + student.TotalCourseUnitRegistered);
            Console.WriteLine("\n\t\tTotal Course Unit Passed:     " + student.TotalCourseUnitPassed);
            Console.WriteLine("\n\t\tTotal Course Weight Point:    " + student.TotalWeightPoint);
            Console.WriteLine("\n\t\tGPA:                          " + student.GPA);
            


        }
    }
}
