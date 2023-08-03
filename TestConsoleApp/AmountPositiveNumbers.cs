using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TestConsoleApp
{
    /// <summary>
    /// Cумма всех положительных элементов массива
    /// </summary>
    public static class AmountPositiveNumbers
    {
        // <summary>
        /// Возвращает сумму всех положительных элементов массива
        /// </summary>
        /// <param name="array">Массив</param>
        public static int SumOfPositiveElements(int[] array)
        {
            int sum = 0;

            foreach (int element in array)
            {
                if (element > 0)
                {
                    sum += element;
                }
            }

            return sum;
        }

        /// <summary>
        /// Выводит информацию
        /// </summary>
        public static void ShowInfo(int sum)
        {
            if (sum > 0)
            {
                WriteLine("Cумма всех положительных элементов массива " + sum);
            }
            else
            {
                WriteLine("К сожалению, в массиве не оказалось ни одного положительного числа");
            }
            WriteLine("Нажмите любую клавишу, чтобы выйти...");
            ReadKey();
        }
    }
}
