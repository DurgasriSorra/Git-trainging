using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    public class Circle
    {
        
        private double PI = 3.14159;
        private double radius;

        public Circle()
        {
            radius = 0.0;
        }

        public Circle(double r)
        {
            radius = r;
        }

        public void setRadius(double r)
        {
            this.radius = r;
        }

        public double getRadius()
        {
            return radius;
        }

        public double getArea()
        {
            return Math.PI * radius * radius;
        }

        public double getDiameter()
        {
            return radius * 2;
        }

        public double getCircumference()
        {
            return 2 * PI * radius;
        }
    }

    class CircleTest
    {
        public static void Main1()
        {
            Circle c1 = new Circle();
            c1.setRadius(2);
            Console.WriteLine(c1.getRadius());
            Console.WriteLine(c1.getDiameter());
            Console.WriteLine(c1.getArea());

            c1.setRadius(4);
            Console.WriteLine(c1.getRadius());
            Console.WriteLine(c1.getDiameter());
            Console.WriteLine(c1.getArea());
        }
    }
}
