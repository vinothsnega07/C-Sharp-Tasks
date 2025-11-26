using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public interface IService
    {
        void add();
       // void displayStudents();
        List<Student> getStudents();
    }
}
