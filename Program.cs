using static test228.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace test228
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string switchKey = "start";
            while (switchKey != "exit")
            {
                Console.WriteLine("Для продолжения нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
                PrintMenu();
                switchKey = Console.ReadLine();
                switch (switchKey)
                {
                    case "Triangle":
                        {
                            Console.WriteLine("Введите длины сторон треугольника:");
                            List<string> sides = new List<string>(3);
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write($"{i + 1}: ");
                                sides.Add(Console.ReadLine());
                            }
                            string side = "4";
                            while ((int.Parse(side) != 1) && (int.Parse(side) != 2) && (int.Parse(side) != 3))
                            {
                                Console.Write("Введите номер стороны, к которой будет опущена высота!");
                                side = Console.ReadLine();
                            }
                            Validator validator = new Validator();
                            if (validator.typeError(sides) || validator.valueError(sides))
                            {
                                if (validator.valueError(sides))
                                {
                                    Console.WriteLine("Допущена ошибка при вводе значений: длина стороны не может быть отрицательной!");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Допущена ошибка при вводе значений: длина должна выражаться числом!");
                                    break;
                                }
                            }
                            else
                            {
                                Triangle triangle = new Triangle(double.Parse(sides[0]), double.Parse(sides[1]), double.Parse(sides[2]), Convert.ToInt32(side));
                                if (triangle.PrivateTriangleValidation())
                                {
                                    triangle.ShowInfo();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Некорректный ввод длин сторон!");
                                    break;
                                }
                            }
                        }
                    case "Circle":
                        {
                            Console.Write("Введите радиус окружности:");
                            List<string> radius = new List<string>();
                            radius.Add(Console.ReadLine());
                            Validator validator = new Validator();
                            if (validator.typeError(radius) || validator.valueError(radius))
                            {
                                if (validator.valueError(radius))
                                {
                                    Console.WriteLine("Допущена ошибка при вводе значений: длина радиуса не может быть отрицательной!");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Допущена ошибка при вводе значений: длина должна выражаться числом!");
                                    break;
                                }
                            }
                            else
                            {
                                Circle circle = new Circle(Convert.ToDouble(radius[0]));
                                circle.ShowInfo();
                                break;
                            }
                        }
                    case "Square":
                        {
                            Console.Write("Введите сторону квадрата:");
                            string length = Console.ReadLine();
                            List<string> a = new List<string>() { length };
                            Validator validator = new Validator();
                            if (validator.typeError(a) || validator.valueError(a))
                            {
                                if (validator.valueError(a))
                                {
                                    Console.WriteLine("Допущена ошибка при вводе значений: длина стороны не может быть отрицательной!");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Допущена ошибка при вводе значений: длина должна выражаться числом!");
                                    break;
                                }
                            }
                            else
                            {
                                Square square = new Square(Convert.ToDouble(a[0]));
                                square.ShowInfo();
                                break;
                            }
                        }
                    case "Rectangle":
                        {
                            Console.WriteLine("Введите стороны прямоугольника:");
                            Console.Write("a: ");
                            string length1 = Console.ReadLine();
                            Console.Write("b: ");
                            string length2 = Console.ReadLine();
                            List<string> a = new List<string>() { length1, length2 };
                            Validator validator = new Validator();
                            if (validator.typeError(a) || validator.valueError(a))
                            {
                                if (validator.valueError(a))
                                {
                                    Console.WriteLine("Допущена ошибка при вводе значений: длина радиуса не может быть отрицательной!");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Допущена ошибка при вводе значений: длина должна выражаться числом!");
                                    break;
                                }
                            }
                            else
                            {
                                Rectangle rectangle = new Rectangle(Convert.ToDouble(a[0]), Convert.ToDouble(a[1]));
                                rectangle.ShowInfo();
                                break;
                            }
                        }
                }
            }
        }
        private static void PrintMenu()
        {
            Console.WriteLine("Введите Triangle для работы с треугольником");
            Console.WriteLine("Введите Rectangle для работы с прямоугольником");
            Console.WriteLine("Введите Circle для работы с окружностью");
            Console.WriteLine("Введите Square для работы с квадратом");
        }
    }
}
