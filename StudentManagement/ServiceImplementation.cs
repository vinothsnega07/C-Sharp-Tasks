using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class ServiceImplementation : IService
    {
        public void add()
        {
            Console.WriteLine("Enter StudentId: ");
            int id= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Dept: ");
            string dept = Console.ReadLine();
            //Student s = new Student(id,name,age,dept);
            DB.students.Add(id,(new Student(id,name,age,dept)));
            //DB.students.Add((new Student(name, age, dept)));
            Console.WriteLine("Students Are Added Sucessfully!");
        }
        //public void displayStudents()
        //{
        //    foreach (Student s in DB.students)
        //    {
        //        Console.WriteLine("Name: " + s.getName());
        //        Console.WriteLine("Age: " + s.getAge());
        //        Console.WriteLine("Dept: " + s.getDept());
        //    }
        //}

        public Dictionary<int, Student> getStudents()
        {
            //Console.WriteLine("Enter Student Name: ");
            //string name=Console.ReadLine();
            //Console.WriteLine("Enter Age: ");
            //int age=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Dept: ");
            //string dept=Console.ReadLine();
            //Student s =new Student(name,age,dept);
            Dictionary<int,Student> dictStudents= DB.students;
            return dictStudents;

        }
    }
}
