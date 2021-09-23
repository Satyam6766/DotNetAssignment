using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAssessment3_Qus8_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            Console.WriteLine("Enter name of student");
            t1.Name = Console.ReadLine();
            Console.WriteLine("Enter name of student");
            t1.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name of student is: " + t1.Name);
            Console.WriteLine("Age of student is: " + t1.Age);
            Console.ReadLine();
        }
    }
    public class Test
    {

        
         String studentName;       //Variable declared here are private.As bydefault var are private.
         int studentAge;           //These var can not be aquired outside class as there scope is private.

       //We can now use accessor[Properties] to access these var.

        public string Name
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }
        public int Age
        {
            get
            {
                return studentAge;
            }
            set
            {
                studentAge = value;
            }
        }


    }
}
