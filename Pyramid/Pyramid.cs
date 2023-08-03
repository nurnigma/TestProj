using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Pyramid
{
    /// <summary>
    /// Пирамида
    /// </summary>
    public class Pyramid
    {
        /// <summary>
        /// Массив
        /// </summary>
        readonly int[,] matrix;

        /// <summary>
        /// Числовой параметр
        /// </summary>
        readonly int n;

        public Pyramid()
        {
            
        }
        public Pyramid(int n)
        {
            this.n = n;
            matrix = new int[n * 2 - 1, n * 2 - 1];

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n * 2 - 1 - i; j++)
                {
                    matrix[i, j] = i + 1;
                    matrix[n * 2 - 2 - i, j] = i + 1;
                    matrix[j, i] = i + 1;
                    matrix[j, n * 2 - 2 - i] = i + 1;
                }
            }
        }

        /// <summary>
        /// Вывод информации
        /// </summary>
        public void Show()
        {
            for (int i = 0; i < n * 2 - 1; i++)
            {
                for (int j = 0; j < n * 2 - 1; j++)
                {
                    Write(matrix[i, j] + " ");
                }
                WriteLine();
            }

            WriteLine("Нажмите любую клавишу, чтобы выйти...");
            ReadKey();
        }
    }
}
