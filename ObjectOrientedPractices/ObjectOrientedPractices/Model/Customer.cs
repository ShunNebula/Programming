﻿using ObjectOrientedPractices.Services;

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

        private Cart _cart;

        private Order _order;

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
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес покупателя.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }

        public Cart Cart
        {
            get { return _cart; }
            set { _cart = value; }
        }

        public Order Order
        {
            get { return _order; }
            set { _order = value; }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer(string fullName, Address address, Cart cart)
        {
            Id = IdGenerator.GetNextId("Customer");
            FullName = fullName;
            Address = address;
            Cart = cart;
            Order = new Order();
        }
    }
}
