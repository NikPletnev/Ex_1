using System;

namespace Ex_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости: ");
            double X1 = Convert.ToDouble(Console.ReadLine());
            double Y1 = Convert.ToDouble(Console.ReadLine());
            double X2 = Convert.ToDouble(Console.ReadLine());
            double Y2 = Convert.ToDouble(Console.ReadLine());
            double k = (Y2 - Y1) / (X2 - X1);
            double b = k * X1 - Y1;
            Console.WriteLine("Уравнение прямой проходящей через эти точки: Y = " + k + "X" + " + " + b);

        }
    }
}
