using System;
using System.Collections.Generic;
namespace GPACalculator
{
    internal class PrintTable
    {
        public void Table(Student student)
        {
            Console.Clear();
            Console.WriteLine("\n\n\t\t\t<<<<<<<< GPA CALCULATOR >>>>>>>>");
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("\t\t|---------------|---------------|-------------|--------------|----------------|---------------|");
            Console.WriteLine("\t\t|               |               |             |              |                |               |");
            Console.WriteLine("\t\t|  COURSE CODE  |  COURSE UNIT  |    GRADE    |  GRADE UNIT  |  WEIGHTED POINT|    REMARK     |");
            Console.WriteLine("\t\t|               |               |             |              |                |               |");
            Console.WriteLine("\t\t|---------------|---------------|-------------|--------------|----------------|---------------|");
            foreach (KeyValuePair<string, Courses> Entry in student.CoursesDictionary)
            {
                Courses courseData = Entry.Value;
                if (Convert.ToInt16(courseData.WeightPT) >= 10 && Convert.ToInt16(courseData.WeightPT) < 100)
                {
                    Console.WriteLine("\t\t|               |               |             |              |                |              " +
                        " |");
                    Console.WriteLine("\t\t|  " + courseData.CourseCode + "       |       " + courseData.CourseUnit + "       |     " 
                        + courseData.Grade + "   " +
                        "    |     " + courseData.GradeUnit + "        |     " + courseData.WeightPT + "         |  " + courseData.Remark +
                        "    |");
                    Console.WriteLine("\t\t|               |               |             |              |                |               |");
                    Console.WriteLine("\t\t|---------------|---------------|-------------|--------------|----------------|---------------|");
                }
                else
                {
                    Console.WriteLine("\t\t|               |               |             |              |                |               |");
                    Console.WriteLine("\t\t|  " + courseData.CourseCode + "       |       " + courseData.CourseUnit + "       |     " 
                        + courseData.Grade + "   " +
                        "    |     " + courseData.GradeUnit + "        |     " + courseData.WeightPT + "          |  " + courseData.Remark +
                        "    |");
                    Console.WriteLine("\t\t|               |               |             |              |                |               |");
                    Console.WriteLine("\t\t|---------------|---------------|-------------|--------------|----------------|---------------|");
                }
            }
            
        }
    }
}

    
