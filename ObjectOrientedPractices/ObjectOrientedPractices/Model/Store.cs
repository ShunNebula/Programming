using System.Collections.Generic;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Хранит данные о покупателе и товаре
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Список товаров
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Список покупателей
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Возвращает и задаёт список товаров
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает и задаёт список покупателей
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Store"/>.
        /// </summary>
        public Store()
        {
            Items = ItemFactory.Randomize(5);
            Customers = CustomerFactory.Randomize(5);
        }
    }
}
