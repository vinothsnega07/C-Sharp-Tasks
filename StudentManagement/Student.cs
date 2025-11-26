using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student
    {
        public int studentId;
        private string name;
        private int age;
        private string dept;

        public Student(int studentId,string name, int age, string dept)
        {
            this.studentId = studentId;
            this.name = name;
            this.age = age;
            this.dept = dept;
        }

        public int getStudentId()
        {
            return studentId;
        }

        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
        public string getDept()
        {
            return dept;
        }
        
    }
}
