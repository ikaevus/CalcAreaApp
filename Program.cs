using System;

namespace CalcAreaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaTriangle triangle = new AreaTriangle();

            Console.WriteLine("Введите сторону A: ");
            triangle.A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сторону B: ");
            triangle.B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сторону C: ");
            triangle.C = Convert.ToDouble(Console.ReadLine());

            triangle.p = (triangle.A + triangle.B + triangle.C) / 2;

            triangle.S = Math.Sqrt(triangle.p * (triangle.p - triangle.A) * (triangle.p - triangle.B) * (triangle.p - triangle.C));

            Console.WriteLine("Площадь треугольника равна: {0}", triangle.S);
            Console.ReadLine();

            AreaCircle circle = new AreaCircle();
            Console.WriteLine("Введите радиус R:");
            circle.R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь круга равна: {0}", AreaCircle.Square(circle.R));
            Console.ReadLine() ;
        }
    }
}
