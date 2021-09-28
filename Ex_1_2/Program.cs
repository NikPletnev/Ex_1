using System;

namespace Ex_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два строковых значения:");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string buffer = str1;
            str1 = str2;
            str2 = buffer;
            Console.WriteLine("Значение 1: " + str1);
            Console.WriteLine("Значение 2: " + str2);


        }
    }
}
