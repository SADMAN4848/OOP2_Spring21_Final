using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assosciation_Student_Course
{
    class Department
    {
        public string Name { get; set; }
        public string Id { get; set; }
        private Student[] students;
        
        public int StuCount { get; set; }

        public Department()
        {
            students = new Student[40];
            StuCount = 0;
        }
        public Department(string name, string id)
        {
            Name = name;
            Id = id;
            students = new Student[40];
        }
        
        public void AddStudent(params Student[] students)
        {
            
            foreach (Student s in students)
            {
                this.students[StuCount++] = s;
                s.Department = this;
            }
        }
        public void PrintAllStudents()
        {
            
            for (int i = 0; i < StuCount; i++)
            {
                students[i].ShowInfo();
            }
        }
        public Student GetStudent(string id)
        {
            return null;
        }
        
    }
}
