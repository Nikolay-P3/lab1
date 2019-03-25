//Задание 14.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number and press enter: "); //Введите первый номер:
            double a = double.Parse(Console.ReadLine()); 
            Console.Write("Enter second number and press enter: "); //Введите второй номер:
            double b = double.Parse(Console.ReadLine());
            var sum = a + b;
            Console.Write("result="  + Math.Pow(sum, 2)); //Выводится результат.
            Console.ReadKey();
        }
        public static double sum(double a, double b)
            
        {
            return a + b;
        }

    }
}
