using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model.Discounts
{
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает название скидки
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Вычисляет размер скидки
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Возвращает размер скидки</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Возвращает размер скидки</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Вычисляет процент/баллы скидки
        /// </summary>
        /// <param name="items">Список товаров</param>
        void Update(List<Item> items);
    }
}
