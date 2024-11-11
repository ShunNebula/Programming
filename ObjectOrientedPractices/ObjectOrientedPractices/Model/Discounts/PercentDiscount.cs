using ObjectOrientedPractices.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model.Discounts
{
    public class PercentDiscount : IDiscount
    {
        /// <summary>
        /// Текущая скидка в процентах
        /// </summary>
        private double _percent;

        /// <summary>
        /// Сумма, на которую покупатель уже сделал покупки данной категории товаров.
        /// </summary>
        private double _categoryAmount;

        /// <summary>
        /// Возвращает и задаёт текущую скидку в процентах
        /// </summary>
        public double Percent
        { 
            get { return _percent; } 
            private set 
            { 
                if (value > 10 || value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(Percent) + "должна быть от 1% до 10%.");
                }    
                _percent = value; 
            } 
        }

        /// <summary>
        /// Возвращает и задаёт категорию
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает и задаёт сумму, на которую покупатель уже сделал покупки данной категории товаров.
        /// </summary>
        public double CategoryAmount
        {
            get { return _categoryAmount; }
            set { _categoryAmount = value; }
        }

        /// <summary>
        /// Возвращает название скидки «Процентная «{Категория}» - {Процент}%»
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная «{Category}» - {Percent}%";
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="category">Выбранная категория</param>
        public PercentDiscount(Category category)
        {
            Percent = 1;
            Category = category;
        }

        /// <summary>
        /// Вычисляет размер скидки
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Возвращает размер скидки</returns>
        public double Calculate(List<Item> items)
        {
            double categoryCost = 0;
            foreach (Item item in items)
            {
                if (item.Category == Category)
                    categoryCost += item.Cost;
            }
            double perc = categoryCost * (Percent / 100);
            return perc;
        }

        /// <summary>
        /// Применяет скидку
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Возвращает размер скидки</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            Percent = 1;
            CategoryAmount = 0;
            return discount;
        }

        /// <summary>
        /// Вычисляет процент скидки
        /// </summary>
        /// <param name="items">Список товаров</param>
        public void Update(List<Item> items)
        {
            foreach (Item item in items)
            {
                if (item.Category == Category)
                    CategoryAmount += item.Cost;
            }
            if ((CategoryAmount / 1000) > 10)
                Percent = 10;
            else
            {
                if (CategoryAmount / 1000 == 0)
                    Percent = 1;
                else
                    Percent = (int)CategoryAmount / 1000;
            }
        }
    }
}
