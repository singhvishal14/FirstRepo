using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string FirstName;
            //string SecondName;
            //Console.WriteLine("Enter FirstName");
            //FirstName = Console.ReadLine();
            //Console.WriteLine("Enter SecondName");
            //SecondName = Console.ReadLine();
            //Console.WriteLine("Welcome MR" + FirstName + " " + SecondName);
            //.ReadKey();
            string name;
            int age;
            char grade;
            DateTime doj;
            double salary;
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade");
            grade = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of Joining");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Name :\t"+name +"\n Age: "+age+"\n Grade: \t"+grade +"\n Salary: \t"+salary+"\n Date of joining: \t"+doj);
            Console.ReadKey();




            // Console.WriteLine("Welcome to C#");
            // Console.ReadKey();
        }
    }
}
