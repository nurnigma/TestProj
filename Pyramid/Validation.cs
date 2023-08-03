using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    /// <summary>
    /// Валидация
    /// </summary>
    static class Validation
    {
        // <summary>
        /// Проверка и парсинг в int
        /// </summary>
        public static bool GetValidNumberInput(string input, out int number)
        {
            while (!int.TryParse(input, out number) || number == 0 || number == 1)
            {
                Console.WriteLine("Неверные данные. Пожалуйста, введите другое число: ");
                input = Console.ReadLine();
            }
            return true;
        }
    }
}
