using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(-1, -1);
            Circle circle = new Circle(-1);
            Triangle tri = new Triangle(1, 2, 3);
            rec.showInfo();
            circle.showInfo();
            tri.showInfo();

            Console.WriteLine();

            Rectangle rec1 = new Rectangle(10, 20);
            Circle circle1 = new Circle(5);
            Triangle tri1 = new Triangle(2, 2, 3);
            rec1.showInfo();
            circle1.showInfo();
            tri1.showInfo();
        }
    }
    abstract class Shape
    {
        public abstract double getArea();
    }

    public interface show
    {
        void showInfo();
    }//interface

    class Rectangle: Shape, show
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double x, double y)
        {
            if(x > 0 && y > 0)
            {
                Width = x;
                Height = y;
            }
            else
            {
                Width = 0;
                Height = 0;
                Console.WriteLine("边长置0");
            }
        }
        override public double getArea()
        {
            return Width * Height;
        }

        public void showInfo()
        {
            Console.WriteLine("Width = {0} Height = {1} Area = {2}", Width, Height, this.getArea());
        }
    }//Rectangle

    class Circle: Shape, show
    {
        public double R { get; }
        public Circle(double r)
        {
            if (r > 0)
            {
                R = r;
            }
            else
            {
                R = 0;
                Console.WriteLine("半径置0");
            }

        }
        override public double getArea()
        {
            return Math.PI*R*R;
        }
        public void showInfo()
        {
            Console.WriteLine("r = {0} area = {1}", R, this.getArea());
        }
    }//Circle

    class Triangle : Shape, show
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if(a>0 && b>0 && c>0 && a+b>c && a+c>b && b + c > a)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                A = 0;
                B = 0;
                C = 0;
                Console.WriteLine("三边长置0");
            }
        }
        override public double getArea()
        {
            double p = A + B + C;
            p = p / 2;
            return Math.Sqrt(p*(p - A)*(p - B)*(p - C));
        }

        public void showInfo()
        {
            Console.WriteLine("a = {0} b = {1} c = {2} area = {3}", A, B, C, this.getArea());
        }

    }//Triangle

}
