using System;
using System.Collections.Generic;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Хранит данные о корзине покупателя
    /// </summary>
    public class Cart : ICloneable
    {
        /// <summary>
        /// Список товаров
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Возвращает и задаёт список товаров
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает общую стоимость всех товаров
        /// </summary>
        public double Amount
        {
            get
            {
                if (_items == null || _items.Count == 0)
                    return 0.0;

                double totalCost = 0.0;
                for (int i = 0; i < _items.Count; i++)
                {
                    totalCost += _items[i].Cost;
                }
                return totalCost;
            }
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Cart"/>.
        /// </summary>
        /// <param name="items">Список товаров в корзине</param>
        public Cart(List<Item> items)
        {
            Items = items;
        }

        /// <inheritdoc/>
        public object Clone()
        {
            return new Cart( this.Items );
        }
    }
}
