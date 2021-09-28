using System;

namespace Ex_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательно два числа:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            double calculationResult = (5 * number1 + Math.Pow(number2, 2))/(number2-number1); 
            Console.WriteLine("Результат сложения: " + calculationResult);
        }
    }
}
