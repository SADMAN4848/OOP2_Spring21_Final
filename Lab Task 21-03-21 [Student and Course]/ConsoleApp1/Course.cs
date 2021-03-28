using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assosciation_Student_Course
{
    class Course
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int StuCount { get; set; }
        Student[] students;
        
        public Course()
        {
            students = new Student[20];
        }
        public Course(string name, string id)
        {
            Name = name;
            Id = id;
            students = new Student[20];
        }
        public void ShowInfo()
        {
            Console.WriteLine("Course Name: " + Name);
            Console.WriteLine("Course ID: " + Id);
        }
        public void AddStudent(params Student[] students)
        {
            foreach (Student s in students)
            {
                this.students[StuCount] = s;
                StuCount++;
                if (StuCount > 30) { break; }
                else { continue; }
            }
        }
        public void PrintAllStudent()
        {
            for (int i = 0; i < StuCount; i++)
            {
                students[i].ShowInfo();
            }
        }
    }

}
