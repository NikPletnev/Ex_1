using System;

namespace Ex_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательно два числа:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int calculationDivide = number1 / number2;
            int calculationRemainder = number1 % number2;
            Console.WriteLine("Результат деления нацело: " + calculationDivide);
            Console.WriteLine("Остаток от деления: " + calculationRemainder);


        }
    }
}
