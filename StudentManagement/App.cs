
using StudentManagement;

class App
{
    public static void Main(string[] args)
    {

        ServiceImplementation serv = new ServiceImplementation();
        Dictionary<int,Student> res = new Dictionary<int,Student>();
        while (true)
        {
            Console.WriteLine("1.Add Student\n2.Display Student\n3.Exit");
            Console.WriteLine("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    serv.add();
                    break;

                case 2:
                    //serv.displayStudents();
                    //break;
                    
                    foreach (Student s in student)
                    {
                        Console.WriteLine("Name: " + s.getName());
                        Console.WriteLine("Age: " + s.getAge());
                        Console.WriteLine("Dept: " + s.getDept());
                    }
                    break;

                case 3:
                    System.Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

        
    }
}





