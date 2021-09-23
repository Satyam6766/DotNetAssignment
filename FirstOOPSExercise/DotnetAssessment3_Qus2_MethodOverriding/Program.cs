using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAssessment2_Qus2_MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            ParentClass pc = new ParentClass();
            int Area = pc.Area(-3, 5);
            Console.WriteLine("Area is: "+Area);
            Console.WriteLine();
            childClass cc = new childClass();
            int  Area2 = cc.Area(0, -5);
            Console.WriteLine("Area is: " + Area2);
            Console.ReadLine();
        }
    }
    class ParentClass
    {
        public virtual int Area(int l, int b)//Here we calculate Area of Rectangle
        {
            return (l * b);
        }
    }
    class childClass :ParentClass
    {
        public override int Area(int l, int b)//Here we calculate Area of Rectangle
        {
            if(l >= 0 && b >= 0)
            {
                return (l * b);
            }           
            Console.WriteLine("Length and breadth can not be zero or negative");
            Console.WriteLine("Enter length : ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth : ");
            b = Convert.ToInt32(Console.ReadLine());
            return (l * b);
        }
    }
}
