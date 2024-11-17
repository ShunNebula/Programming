using ObjectOrientedPractices.Model.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model.Discounts
{
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {
        /// <summary>
        /// Количество баллов
        /// </summary>
        private int _points;

        /// <summary>
        /// Возвращает и задаёт количество баллов
        /// </summary>
        public int Points 
        { 
            get { return _points; } 
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Points) + "дожен быть положительным.");
                }
                _points = value;
            }
        }

        /// <summary>
        /// Возвращает название скидки «Накопительная – {Баллы} баллов»
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная – {Points} баллов";
            }
        }

        /// <summary>
        /// Вычисляет размер скидки
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Возвращает размер скидки</returns>
        public double Calculate(List<Item> items) 
        {
            double totalCost = 0;
            foreach (Item item in items)
                totalCost += item.Cost;
            double maxDiscount = totalCost * 0.3;
            if (Points > maxDiscount)
                return maxDiscount;
            return Points;
        }

        /// <summary>
        /// Применяет скидку
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Возвращает размер скидки</returns>
        public double Apply(List<Item> items) 
        { 
            double discount = Calculate(items);
            if (Points - discount < 0)
                Points = 0;
            else
                Points = (int)(Points - discount);
            return discount;
        }

        /// <summary>
        /// Вычисляет баллы скидки
        /// </summary>
        /// <param name="items">Список товаров</param>
        public void Update(List<Item> items) 
        {
            double totalCost = 0;
            foreach (Item item in items)
                totalCost += item.Cost;
            Points += (int)Math.Ceiling(totalCost * 0.1);
        }

        /// <inheritdoc/>
        public int CompareTo(PointsDiscount other)
        {
            return Points.CompareTo(other.Points);
        }
    }
}
