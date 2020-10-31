using System;

namespace th4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.Name = "Nishi";
            obj.Id = "19-40374-1";
            obj.Department = "CSE";

            Console.WriteLine("My name is : " + obj.Name);
            Console.WriteLine("My id is : " + obj.Id);

            Console.WriteLine("My department is : " + obj.Department);
            Triangle obj = new Triangle();
            Console.WriteLine("Enter the x: ");
            obj.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y: ");
            obj.Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the z: ");
            obj.Z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x is : " + obj.X);
            Console.WriteLine("y is : " + obj.Y);
            Console.WriteLine("z is : " + obj.Z);
            obj.TestTriangle();
            Account obj = new Account();
            Console.WriteLine("Account name is :" + obj.AccName);
            Console.WriteLine("Account no is :" + obj.Acid);
            Console.WriteLine("Balance is :" + obj.Balance);

            obj.Deposit(200000);
            obj.WithDraw(50000);
            Console.WriteLine("New balance  is :" + obj.Balance);

            Course obj = new Course();
            Console.WriteLine("Enter your course name: ");
            obj.CourseName = Console.ReadLine();
            Console.WriteLine("Enter your course code: ");
            obj.CourseCode = Console.ReadLine();
            Console.WriteLine("Enter your course credit: ");
            obj.CourseCredit = Convert.ToInt32(Console.ReadLine());

            obj.ShowCourseInfo();


        }

    }
}
