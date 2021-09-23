using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAssessment3_Qus3
{
    class Program
    {
        static void Main(string[] args)
        {
            IFirstInterface firstInterfaceObj = new Test();
            firstInterfaceObj.Method1();
            ISecondInterface secondInterfaceObj = new Test();
            secondInterfaceObj.Method1();
            Console.ReadKey(true);
            //Like this we can implement 2 different interface with same name
            //Also in this version of C#  we can not use PUBLIC keyword in Methods in class.

        }
    }
    interface IFirstInterface
    {
        void Method1();
    }
    interface ISecondInterface
    {
        void Method1();
    }
    class Test : IFirstInterface, ISecondInterface
    {
        void IFirstInterface.Method1()     //PUBLIC keyword is not valid here.
        {
            Console.WriteLine("This method is of First Interface");
        }
        void ISecondInterface.Method1()
        {
            Console.WriteLine("This method is of second Interface");
        }
    }
}
