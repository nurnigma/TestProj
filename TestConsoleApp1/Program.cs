﻿using System;

namespace TestConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Размер массима строго задан
            const uint size = 6;

            // Минимальное значение для рандома
            const int minValueRandom = -100;

            // Максимальное значение для рандома
            const int maxValueRandom = 100;

            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(minValueRandom, maxValueRandom);

            int positiveSumAndAbsOfNegatives = AmountPositiveNumbersAndAbs.SumOfPositivesAndAbsOfNegatives(array);

            AmountPositiveNumbersAndAbs.ShowInfo(positiveSumAndAbsOfNegatives);

        }
    }
}
