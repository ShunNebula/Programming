using ObjectOrientedPractices.Services;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Хранит данные о заказе
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный id
        /// </summary>
        private int _id;

        /// <summary>
        /// Дата создания заказа
        /// </summary>
        private string _date;

        /// <summary>
        /// Адрес доставки
        /// </summary>
        private Address _address;

        /// <summary>
        /// Список товаров
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Общая цена товаров из списка
        /// </summary>
        private double _amount;

        private OrderStatus _status;

        /// <summary>
        /// Возвращает уникальный id
        /// </summary>
        public int Id 
        { 
            get { return _id; } 
            private set { _id = IdGenerator.GetNextId("Order"); }
        }

        /// <summary>
        /// Возвращает дату создания заказа
        /// </summary>
        public string Date 
        { 
            get { return _date; } 
            private set { _date = DateTime.Now.ToString(); }
        }

        /// <summary>
        /// Возвращает и задаёт адрес доставки
        /// </summary>
        public Address Address { get { return _address; } set { _address = value; } }

        /// <summary>
        /// Возвращает и задаёт список товаров
        /// </summary>
        public List<Item> Items { get { return _items; } set { _items = value; } }

        /// <summary>
        /// Возвращает и задаёт общую цену товаров из списка
        /// </summary>
        public double Amount { get { return _amount; } set { _amount = value; } }

        public OrderStatus Status { get { return _status; } set { _status = value; } }
    }
}
