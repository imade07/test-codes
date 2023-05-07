using System;

namespace GPACalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Prompt the user to enter the course name and code
            Console.WriteLine("Enter the course name and code:");
            string courseName = Console.ReadLine();
            string courseCode = Console.ReadLine();

            // Prompt the user to enter the course unit
            Console.WriteLine("Enter the course unit:");
            int courseUnit = int.Parse(Console.ReadLine());

            // Prompt the user to enter the course score
            Console.WriteLine("Enter the course score:");
            int courseScore = int.Parse(Console.ReadLine());

            // Create a new GPACalculator object
            var calculator = new GPACalculator();
            // Calculate the grade
            int grade = calculator.CalculateGrade(courseScore);

            // Add the course to the calculator
            calculator.AddCourse(courseName, courseCode, courseUnit, grade);

            // Calculate the GPA
            double gpa = calculator.CalculateGPA();

            // Print the results
            calculator.PrintResults();
        }

        public int CalculateGrade(int score)
        {
            if (score >= 70)
            {
                return 5;
            }
            else if (score >= 60)
            {
                return 4;
            }
            else if (score >= 50)
            {
                return 3;
            }
            else if (score >= 45)
            {
                return 2;
            }
            else if (score >= 40)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public double CalculateGPA()
        {
            double totalWeightPoint = 0;
            double totalCourseUnit = 0;

            foreach (var course in courses)
            {
                totalWeightPoint += course.CourseUnit * course.GradeUnit;
                totalCourseUnit += course.CourseUnit;
            }

            return totalWeightPoint / totalCourseUnit;
        }

        public void AddCourse(string courseName, string courseCode, int courseUnit, int grade)
        {
            courses.Add(new Course
            {
                CourseName = courseName,
                CourseCode = courseCode,
                CourseUnit = courseUnit,
                Grade = grade,
                GradeUnit = grade * courseUnit
            });
        }

        public void PrintResults()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("| COURSE & CODE | COURSE UNIT | GRADE | GRADE-UNIT | WEIGHT Pt. | REMARK |");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            foreach (var course in courses)
            {
                Console.WriteLine("{0,-15} | {1,-10} | {2,-3} | {3,-5} | {4,-8} | {5,-10}",
                    course.CourseName, course.CourseUnit, course.Grade, course.GradeUnit, course.WeightPoint, course.Remark);
            }

            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("Total Course Unit Registered is {0}", totalCourseUnit);
            Console.WriteLine("Total Course Unit Passed is {0}", totalPassedCourseUnit);
            Console.WriteLine("Total Weight Point is {0}", totalWeightPoint);
            Console.WriteLine("Your GPA is = {0:N2}", gpa);
        }

        private List<Course> courses = new List<Course>();
        private int totalPassedCourseUnit = 0;
    }

    class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int CourseUnit { get; set; }
        public int Grade { get; set; }
        public int GradeUnit { get; set; }
        public string Remark { get; set; }
    }
}