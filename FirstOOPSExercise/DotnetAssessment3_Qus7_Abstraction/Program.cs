using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAssessment3_Qus7_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter values for x,y,z");
            Console.WriteLine("Enter X");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter z");
            z = Convert.ToInt32(Console.ReadLine());
            ChildClass obj = new ChildClass(x,y,z);
            obj.Print();
            Console.ReadLine();
        }
    }
    class ParentClass
    {
        int x, y, z;
        public ParentClass(int X,int Y,int Z)
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }
        public void Print()
        {
            Console.WriteLine("Value of x,y and z is:"+x+" ,"+y+" ,"+z);
        }
    }
    class ChildClass : ParentClass
    {
        public ChildClass(int X, int Y, int Z) : base(X, Y, Z)
        {

        }
    }
}
