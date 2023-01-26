using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test228
{
    public abstract class Shapes
    {
        public string Name { get; set; }
        public abstract double GetPerimeter();
        public abstract double GetArea();
        public abstract void ShowInfo();
    }

    public class Validator
    {
        public bool typeError(List<string> values)
        {
            foreach (string value in values)
            {
                if (!double.TryParse(value, out double result))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public bool valueError(List<string> values)
        {
            if (!typeError(values))
            {
                foreach (string value in values)
                {
                    if (double.Parse(value) < 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
    }

    public class Rectangle : Shapes
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetPerimeter() => Width * 2 + Height * 2;

        public override double GetArea() => Width * Height;
        public double GetDiagonal() => Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2));
        public override void ShowInfo()
        {
            Console.WriteLine($"Периметр прямоугольника p={GetPerimeter()} ");
            Console.WriteLine($"Площадь прямоугольника s={GetArea()} ");
            Console.WriteLine($"Диагональ прямоугольника d={GetDiagonal()} ");
        }
    }
    public class Circle : Shapes
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override double GetPerimeter() => Radius * 2 * Math.PI;

        public override double GetArea() => Radius * Radius * Math.PI;
        public override void ShowInfo()
        {
            Console.WriteLine($"Периметр окружности p={GetPerimeter()} ");
            Console.WriteLine($"Площадь окружности s={GetArea()} ");
            Console.WriteLine($"Диаметр окружности p={2 * Radius} ");
        }
    }
    public class Square : Shapes
    {
        public Square(double length)
        {
            this.length = length;
        }

        public double length;
        public override double GetArea() => Math.Pow(length, 2);

        public override double GetPerimeter() => length * 4;
        public double GetDiagonal() => Math.Sqrt(2 * Math.Pow(length, 2));
        public override void ShowInfo()
        {
            Console.WriteLine($"Периметр квадрата p={GetPerimeter()} ");
            Console.WriteLine($"Площадь квадрата s={GetArea()} ");
            Console.WriteLine($"Диагональ квадрата d={GetDiagonal()} ");
        }
    }
    public class Triangle : Shapes
    {
        public Triangle(double side1, double side2, double side3, int side)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.side = side;
        }
        double side1, side2, side3;
        int side;
        public bool PrivateTriangleValidation()
        {
            if (side1 + side2 < side3 || side2 + side3 < side1 || side1 + side3 < side2)
            { Console.WriteLine("Некорректно введены данные"); return false; }
            else
            {
                return true;
            }
        }
        public override double GetArea()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Pow(p * (p - side1) * (p - side2) * (p - side3), 2);
        }
        public override double GetPerimeter()
        {
            return side1 + side2 + side3;
        }
        public double GetHigh(int side)
        {
            List<double> sides = new List<double> { side1, side2, side3 };
            return (2 * GetArea()) / sides[side];
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Периметр треугольника p={GetPerimeter()} ");
            Console.WriteLine($"Площадь треугольника s={GetArea()} ");
            Console.WriteLine($"Высота треугольника, проведенная к {side}-ой стороне h={GetHigh(side)}");
        }
    }
}
