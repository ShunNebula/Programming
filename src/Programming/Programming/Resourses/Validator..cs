using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Programming.Model
{
    /// <summary>
    /// Вспомагательный класс для проверки значений.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет число тип int на положительность.
        /// </summary>
        /// <param name="num">Проверяемое число.</param>
        /// <param name="property">Название свойства.</param>
        /// <exception cref="ArgumentException">Выбрасывает исключенике типа ArgumentException, если число меньше 0.</exception>
        public static void AssertOnPositiveValue(int num, string property)
        {
            if (num < 0) throw new ArgumentException($"Value can't be negative: '{property}' = '{num}'.");
        }
        /// <summary>
        /// Проверяет число тип double на положительность.
        /// </summary>
        /// <param name="num">Проверяемое число.</param>
        /// <param name="property">Название свойства.</param>
        /// <exception cref="ArgumentException">Выбрасывает исключенике типа ArgumentException, если число меньше 0.</exception>
        public static void AssertOnPositiveValue(double num, string property)
        {
            if (num < 0) throw new ArgumentException($"Value can't be negative: '{property}' = '{num}'.");
        }
        /// <summary>
        /// Проверяет входит ли число в данный промежуток.
        /// </summary>
        /// <param name="num">Проверяемое число.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <param name="property">Название свойства.</param>
        /// <exception cref="ArgumentException">Выбрасывает исключенике типа ArgumentException, если число меньше минимального значения или больше заданного максимального значения.</exception>
        public static void AssertValueInRange(double num, double min, double max, string property)
        {
            if (num < min || num > max) throw new ArgumentException($"Value is out of range ({min}-{max}): '{property}' = '{num}'.");
        }
    }
}
