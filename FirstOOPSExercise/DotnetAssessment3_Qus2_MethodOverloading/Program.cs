using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAssessment2_Qus2_MethodOverloading
{
    class Program
    {
        public int Area(int s) //Here we calculate Area of Square 
        {
            return (s * s);
        }
        public int Area(float s) //Here we calculate Area of Square
        {
            return (Convert.ToInt32(s * s));
        }
        public int Area(int l, int b)//Here we calculate Area of Rectangle
        {
            return (l * b);
        }
        public int Area(int l, int b, int h)//Here we calculate Area of 3-D figure
        {
            return (l * b * h);
        }
        public float Area(float l, float b)
        {
            return (l * b);
        }
        public float Area(float l, float b, float h)
        {
            return (l * b * h);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Area for square having side dimension in int is:" + obj.Area(3));
            Console.WriteLine("Area for square having side dimension in float is:" + obj.Area(3.5f));
            Console.WriteLine("Area for rectange  having sides dimension[length and breadth] in int is:" + obj.Area(3, 4));
            Console.WriteLine("Area for rectange  having sides dimension[length and breadth] in float is:" + obj.Area(3.4f, 4.8f));
            Console.WriteLine("Area for 3-D figure having sides dimension[length,breadth and height] in int is:" + obj.Area(3, 4), 7);
            Console.WriteLine("Area for 3-D figure having sides dimension[length,breadth and height] in float is:" + obj.Area(3.4f, 4.8f, 2.4f));
            Console.ReadLine();
            //Here we have called multiple method having same name "AREA" but the type and number of argument passed in the methods are different.
        }
    }
}
