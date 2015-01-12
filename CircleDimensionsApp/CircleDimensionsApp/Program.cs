using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleDimensionsApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle Circle1=new Circle();
            Circle1.radius = 2;
            Console.WriteLine(Circle1.GetDiameter());
            Console.WriteLine(Circle1.GetPerimeter());
            Console.WriteLine(Circle1.GetArea());
            
            Circle Circle2=new Circle();
            Circle2.radius = 10;
            Console.WriteLine(Circle2.GetDiameter());
            Console.WriteLine(Circle2.GetPerimeter());
            Console.WriteLine(Circle2.GetArea());

            Circle Circle3 = new Circle(); 
            Circle3.radius = 15;
            Console.WriteLine(Circle3.GetDiameter());
            Console.WriteLine(Circle3.GetPerimeter());
            Console.WriteLine(Circle3.GetArea());
            Console.ReadKey();
        } 
    }
}
