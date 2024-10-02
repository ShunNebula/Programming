using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Вспомогательный класс для проверки значений.
    /// </summary>
    public class ValueValidator
    {
        /// <summary>
        /// Проверяет длину строки.
        /// </summary>
        /// <param name="value">Вводимая строка</param>
        /// <param name="maxLength">Максимальная длина строки</param>
        /// <param name="propertyName">Название свойства</param>
        /// <exception cref="ArgumentNullException">Выбрасывает исключение типа ArgumentException, Если длина чтроки больше заданной максимальной границы</exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength) throw new ArgumentNullException(propertyName + " должен быть меньше " + maxLength.ToString());
        }

        /// <summary>
        /// Проверяет входит ли число в данный промежуток.
        /// </summary>
        /// <param name="num">Проверяемое число</param>
        /// <param name="min">Минимальная граница</param>
        /// <param name="max">Максимальная граница</param>
        /// <param name="propertyName">Название свойства</param>
        /// <exception cref="ArgumentOutOfRangeException">Выбрасывает исключение типа ArgumentException, если число меньше минимального значения или больше заданного максимального значения</exception>
        public static void AssertValueInRange(double num, double min, double max, string propertyName)
        {
            if (num < min ||  num > max) throw new ArgumentOutOfRangeException(propertyName + " должен быть от " + min.ToString() + " и до " + max.ToString());
        }
    }
}
