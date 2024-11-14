using ObjectOrientedPractices.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Хранит данные о покупателе
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Полное имя (фио) покупателя
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Адрес покупателя
        /// </summary>
        private Address _address;

        /// <summary>
        /// Корзина покупателя
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Список заказов покупателя
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Возвращает и задаёт уникальный номер покупателя
        /// </summary>
        public int Id
        {
            get;
            private set;
        }

        /// <summary>
        /// Возвращает и задаёт полное имя покупателя. Должно быть не длиннее 200 символов.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                try
                { 
                    ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                    _fullName = value;
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес покупателя.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Возвращает и задаёт корзину покупателя
        /// </summary>
        public Cart Cart
        {
            get { return _cart; }
            set { _cart = value; }
        }

        /// <summary>
        /// Возвращает и задаёт список заказов
        /// </summary>
        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        /// <summary>
        /// Возвращает и задаёт приоритетность покупателя
        /// </summary>
        public bool IsPriority { get; set; } = false;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer(string fullName, Address address, Cart cart)
        {
            Id = IdGenerator.GetNextId<Customer>();
            FullName = fullName;
            Address = address;
            Cart = cart;
        }
    }
}
