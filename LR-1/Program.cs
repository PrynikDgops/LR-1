using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1
{
    internal class Program
    {
        static double InputNonNegativeDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out double value) && value >= 0)
                    return value;
                Console.WriteLine("Ошибка: введите число не меньше нуля.");
            }
        }
        static void Main(string[] args)
        {
            double orderCost = InputNonNegativeDouble("Введите стоимость заказа (руб.): ");
            double distance = InputNonNegativeDouble("Введите расстояние доставки (км): ");
        }
    }
}
