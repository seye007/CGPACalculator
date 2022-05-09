using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GPACalculator
{
    internal class Validation
    {
        public string Command(string command)
        {    
            while (true)
            {
                if (command == "1")
                {
                    break;
                }
                else if (command == "2")
                {
                    break ;
                }
                else
                {
                    Console.WriteLine("\n\t\tInvalid Command, enter \"1\" to add courses or \" 2\" to calucalte GPA: ");
                    command = Console.ReadLine();
                }
            }
            return command;
        }

        public string CourseCode(string code)
        { 
            code = code.Trim();
            
            while (true)
            {
                Regex rgx = new Regex("^[a-zA-Z]{3}[1-9]{1}[0-9]{2}$");
                if (rgx.IsMatch(code)) 
                {
                    break;

                }
                else
                {
                    Console.WriteLine("\nCourse code must be 6 characters");
                    Console.WriteLine("\nCourse code must contain three letters and three digits");
                    Console.Write("\nEnter course code: ");
                    code = Console.ReadLine();
                   
                }
            }
            return code; 
        }


        public string ValidateGradeUnit(string grade)
        {
            grade = grade.Trim();

            int number;
            while (true)
            {
                if (int.TryParse(grade, out number))
                {
                    if (Convert.ToInt32(grade) >= 0 && Convert.ToInt32(grade) <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("\nInvalid score, score must be between 0 - 100: ");
                        grade = Console.ReadLine();
                    }

                }
                else
                {
                    Console.Write("\nInvalid score, score must be a number: ");
                    grade = Console.ReadLine();
                }
                
            }
            return number.ToString();
        }

        public string ValidateCourseUnit(string courseUnit)
        {
            courseUnit = courseUnit.Trim();
            int number;
            while (true)
            {
                if(int.TryParse(courseUnit, out number))
                {
                    if (Convert.ToInt32(courseUnit) >= 1 && Convert.ToInt32(courseUnit) <= 5)
                    {
                        
                        break;
                    }
                    else
                    {
                        Console.Write("\nInvalid grade unit, grade unit must be between 1 - 5: ");
                        courseUnit = Console.ReadLine();
                    }
                }
                else
                {
                    Console.Write("\nInvalid grade unit, course unit must be a number: ");
                    courseUnit = Console.ReadLine();
                }
               

            }
            return number.ToString();
        }
    }
}
