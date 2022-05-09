using System;
using System.Collections.Generic;


namespace GPACalculator
{
    internal class Student
    {
        
        public double TotalCourseUnitRegistered;
        public double TotalCourseUnitPassed;
        public double TotalWeightPoint;
        public double GPA;
        public Dictionary<string, Courses> CoursesDictionary = new Dictionary<string, Courses>();

        public void GPACalculator()
        {
            foreach(KeyValuePair<string,Courses> course in CoursesDictionary)
            {
                Courses eachCourse =  course.Value;  
                TotalCourseUnitRegistered += Convert.ToDouble(eachCourse.CourseUnit);
                TotalWeightPoint += Convert.ToDouble(eachCourse.WeightPT);

                if(Convert.ToInt32(eachCourse.Score) > 39)
                {
                    TotalCourseUnitPassed += Convert.ToDouble(eachCourse.CourseUnit);
                }
            }

            GPA = TotalWeightPoint / TotalCourseUnitRegistered;
            GPA = Math.Round(GPA, 2);

        }
    }
}
