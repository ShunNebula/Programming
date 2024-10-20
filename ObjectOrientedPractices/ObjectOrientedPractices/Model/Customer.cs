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
        private string _address;

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
        /// Возвращает и задаёт адрес покупателя. Должен быть не длиннее 500 символов.
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer(string fullName, string address)
        {
            Id = IdGenerator.GetNextId("Customer");
            FullName = fullName;
            Address = address;
        }
    }
}
