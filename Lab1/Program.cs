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
        static void Main()
        {
            var res = SquareSum(1, 2);
            Console.WriteLine("Ответ: {0}", res); //Выведет 9.
            Console.ReadKey();
        }

        static double SquareSum(double x, double y)
        {
            double sum = x + y;
            double result = Math.Pow(sum, 2);

            return result;
        }
    }
}
