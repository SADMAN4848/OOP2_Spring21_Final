using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assosciation_Student_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Department dp1 = new Department("Computer Science", "CS");
            Department dp2 = new Department("Electrical Engineering", "EEE");
            Student s1 = new Student("Sadman Rahman", "18-38832-3", 3.62f);
            Student s2 = new Student("Khalid Labib", "18-34675-1", 3.30f);
            Student s3 = new Student("Wasy Islam", "17-46635-2", 3.34f);
            Course c1 = new Course("Java", "CS121");
            Course c2 = new Course("Bangladesh Studies", "BG353");
            Course c3 = new Course("TOC", "CS378");
            Course c4 = new Course("DLC", "EEE546");
            Course c5 = new Course("C Sharp", "CS358");


            dp1.AddStudent(s1, s2);
            dp2.AddStudent(s3);

            s1.ShowInfo();
            s1.AddCourse(c1, c2, c3);
            s1.PrintAllCourse();
            s1.DropCourse(c1);
            s1.PrintAllCourse();

            Console.WriteLine("=======================");
            s2.ShowInfo();
            s2.AddCourse(c2, c3, c4);
            s2.PrintAllCourse();
            s2.DropCourse(c3);
            s2.PrintAllCourse();


            
        }
    }
}
