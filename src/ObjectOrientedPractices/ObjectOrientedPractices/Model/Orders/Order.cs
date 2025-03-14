﻿using ObjectOrientedPractices.Services;
using ObjectOrientedPractices.Model.Enums;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractices.Model.Orders
{
    /// <summary>
    /// Хранит данные о заказе
    /// </summary>
    public class Order : IEquatable<Order>
    {
        /// <summary>
        /// Уникальный id
        /// </summary>
        private int _id;

        /// <summary>
        /// Дата создания заказа
        /// </summary>
        private DateTime _date;

        /// <summary>
        /// Адрес доставки
        /// </summary>
        private Address _address;

        /// <summary>
        /// Список товаров
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Общая цена товаров из списка
        /// </summary>
        private double _amount;

        /// <summary>
        /// Статус заказа
        /// </summary>
        private OrderStatus _status;

        /// <summary>
        /// Возвращает уникальный id
        /// </summary>
        public int Id 
        { 
            get { return _id; } 
            private set { _id = value; }
        }

        /// <summary>
        /// Возвращает дату создания заказа
        /// </summary>
        public DateTime Date 
        { 
            get { return _date; } 
            private set { _date = value; }
        }

        /// <summary>
        /// Возвращает и задаёт адрес доставки
        /// </summary>
        public Address Address 
        { 
            get { return _address; } 
            set { _address = value; } 
        }

        /// <summary>
        /// Возвращает и задаёт список товаров
        /// </summary>
        public List<Item> Items 
        { 
            get { return _items; } 
            set { _items = value; } 
        }

        /// <summary>
        /// Возвращает и задаёт общую цену товаров из списка
        /// </summary>
        public double Amount 
        { 
            get { return _amount; } 
            set { _amount = value; } 
        }

        /// <summary>
        /// Возвращает и задаёт статус заказа
        /// </summary>
        public OrderStatus Status 
        { 
            get { return _status; } 
            set { _status = value; } 
        }

        /// <summary>
        /// Возвращает и задаёт размер примененной скидки
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Возвращает конечную стоимость заказа
        /// </summary>
        public double Total 
        { 
            get { return Amount - DiscountAmount; } 
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order() { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Адрес доставки</param>
        /// <param name="items">Список товаров</param>
        /// <param name="amount">Общая цена товаров из списка</param>
        /// <param name="status">Статус заказа</param>
        /// <param name="discountAmount">Сумма скидки</param>
        public Order(Address address, List<Item> items, double amount, OrderStatus status, double discountAmount)
        {
            Id = IdGenerator.GetNextId<Order>();
            Date = DateTime.Now;
            Address = address;
            Items = items;
            Amount = amount;
            Status = status;
            DiscountAmount = discountAmount;
        }

        /// <inheritdoc/>
        public bool Equals(Order other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id;
        }

        /// <inheritdoc/>
        public override bool Equals(object other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            if (other.GetType() != this.GetType()) return false;
            return Equals((Order)other);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
