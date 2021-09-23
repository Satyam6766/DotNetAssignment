using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAssessment3_Qus5_VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, b, h;
            Console.WriteLine("Enter  Parameters for 3D Figure:");
            Console.WriteLine("Enter Lenght");
             l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height");
            h = Convert.ToInt32(Console.ReadLine());
            ThreeD_Figure obj = new ThreeD_Figure(l, b, h);
            obj.Area();
            Console.WriteLine("");

            Console.WriteLine("Enter  Parameters for rectangle Figure:");
            Console.WriteLine("Enter Lenght");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            b = Convert.ToInt32(Console.ReadLine());
            h = 0;
            Rectangle rectangle = new Rectangle(l, b, h);
            rectangle.Area();

            Console.ReadLine();

        }
    }
    class Dimension
    {
        public int length = 0;
        public int breadth = 0;
        public int height = 0;
        public Dimension(int l, int b, int h)
        {
            this.length = l;this.breadth = b;this.height = h;            
        }
        public virtual void Area()
        {
            Console.WriteLine("Area is :"+(length*breadth*height));
        }
    }
    class ThreeD_Figure : Dimension
    {
        public ThreeD_Figure(int l, int b, int h):base(l,b,h)
        {
        }
        public override void Area()
        {
            Console.WriteLine("Area of ThreeD_Figure is :" + (length * breadth * height));
        }
    }
    class Rectangle : Dimension
    {
        public Rectangle(int l, int b, int h) : base(l, b, h)
        {
        }
        public override void Area()
        {
            Console.WriteLine("Area of Rectangle is :" + (length * breadth));
        }
    }



}
