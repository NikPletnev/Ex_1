using System;

namespace Ex_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 не равных 0 числа(A,B и C): ");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());
            double X = (C - B) / A;
            Console.WriteLine("Решение(значение X) линейного уравнения стандартного вида, где A*X+B=C: " + X);
        }
    }
}
