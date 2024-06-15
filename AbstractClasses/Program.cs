using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(4.5);
            Rectangle rectangle = new Rectangle(4.5, 6.0);

            Console.WriteLine("Area of Circle: " + circle.GetArea());       
            Console.WriteLine("Area of Rectangle: " + rectangle.GetArea()); 
        }
    }
}
