using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAssessment3_Qus1_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            ParentClass obj1 = new Child1();
            obj1.Method1();
            Console.WriteLine();
            ParentClass obj2 = new Child2();
            obj2.Method1();
            Console.ReadLine();
        }
    }
    public abstract class ParentClass
    {
        public abstract void Method1();
        public void Method2()
        {
            Console.WriteLine("This is not an abstract Method.");
        }
    }
    public class Child1 : ParentClass
    {
        public override void Method1()
        {
            Console.WriteLine("Abstract Method of Parent class is overrided here in Child1 class");
        }
    }
    public class Child2 : ParentClass
    {
        public override void Method1()
        {
            Console.WriteLine("Abstract Method of Parent class is overrided here in Child2 class");
        }
    }
}
