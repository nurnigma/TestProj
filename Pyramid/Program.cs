using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pyramid
{
    class Program
    {

        static void Main(string[] args)
        {
            WriteLine("Введите значение n (целое число): ");
            string input = ReadLine();
            if (Validation.GetValidNumberInput(input, out int n))
            {
                Pyramid pyramid = new Pyramid(n);
                pyramid.Show();
            }
            else
            {
                WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }


        }
    }
}
