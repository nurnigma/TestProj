using System;
using static System.Console;

namespace TestConsoleApp1
{
    /// <summary>
    /// Сумма всех положительных элементов массива и модулей отрицательных элементов массива
    /// </summary>
    public static class AmountPositiveNumbersAndAbs
    {
        /// <summary>
        /// Возвращает сумму всех положительных элементов массива и модулей отрицательных элементов массива
        /// </summary>
        /// <param name="array">Массив</param>
        public static int SumOfPositivesAndAbsOfNegatives(int[] array)
        {
            int sum = 0;

            foreach (int element in array)
            {
                if (element > 0)
                {
                    sum += element;
                }
                else if (element < 0)
                {
                    sum += Math.Abs(element);
                }
            }

            return sum;
        }

        /// <summary>
        /// Выводит в консоль информацию
        /// </summary>
        /// <param name="sum"></param>
        public static void ShowInfo(int sum)
        {
            if (sum > 0)
            {
                WriteLine("Cумма всех положительных элементов массива " + sum);
            }
            else
            {
                WriteLine("Все элементы в массиве заполнены 0");
            }

            WriteLine("Нажмите любую клавишу, чтобы выйти...");
            ReadKey();
        }


    }
}
