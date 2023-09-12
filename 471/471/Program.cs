using System;

namespace _471
{
    public class Shape
    {
        protected double width;
        protected double height;
        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public virtual void GetArea()
        {
            double area = width * height;
            Console.WriteLine("Figure area: " + area);
        }
    }
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        { }
        public override void GetArea()
        {
            double area = width * height;
            Console.WriteLine("Rectangle area: " + area);
        }
    }
    public class Program
    {
        public static void Main()
        {
            Shape shape = new Shape(5, 9);
            shape.GetArea();

            Rectangle rectangle = new Rectangle(7, 9);
            rectangle.GetArea();
            object obj1 = new Shape(1, 3);
            if (obj1 is Shape)
            {
                Shape shapeObj = obj1 as Shape;
                shapeObj.GetArea();
            }

            object obj2 = new Rectangle(3, 7);
            if (obj2 is Rectangle)
            {
                Rectangle rectangleObj = obj2 as Rectangle;
                rectangleObj.GetArea();
            }
        }
    }
}
