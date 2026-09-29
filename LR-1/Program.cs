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
        static int InputIntInRange(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int value) && value >= min && value <= max)
                    return value;
                Console.WriteLine($"Ошибка: введите целое число от {min} до {max}.");
            }
        }
        static bool IsPeakHour(int hour)
        {
            return (hour >= 12 && hour < 14) || (hour >= 18 && hour < 20);
        }
        static double CalculateDeliveryCost(double orderCost, double distance, int hour)
        {
            if (orderCost >= 2000)
                return 0;

            double cost = distance <= 3 ? 150 : 150 + (distance - 3) * 50;

            if (IsPeakHour(hour))
                cost *= 1.3;

            return Math.Round(cost, 2);
        }
        static void Main(string[] args)
        {
            double orderCost = InputNonNegativeDouble("Введите стоимость заказа (руб.): ");
            double distance = InputNonNegativeDouble("Введите расстояние доставки (км): ");
            int hour = InputIntInRange("Введите время заказа (час): ", 0, 23);
            double deliveryCost = CalculateDeliveryCost(orderCost, distance, hour);
        }
    }
}
