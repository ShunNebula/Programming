using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Название товара
        /// </summary>
        private string _name;
        /// <summary>
        /// Подробности о товаре
        /// </summary>
        private string _info;
        /// <summary>
        /// Цена товара
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает и задаёт уникальный номер покупателя
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Возвращает и задаёт название товара. Должно быть не длиннее 200 символов.
        /// </summary>
        public string Name 
        { 
            get { return _name; } 
            set 
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value; 
            } 
        }

        /// <summary>
        /// Возвращает и задаёт подробности о товаре. Должно быть не длиннее 1000 символов.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set 
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value; 
            }
        }

        /// <summary>
        /// Возвращает и задаёт цену товара. Должно быть в диапазоне от 0 до 100000.
        /// </summary>
        public double Cost
        { 
            get { return _cost; } 
            set 
            { 
                ValueValidator.AssertValueInRange(value, 0, 100000, nameof(Cost));
                _cost = value; 
            } 
        }
        /// <summary>
        /// Возвращает и задаёт категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            Id = IdGenerator.GetNextId("Item");
        }
    }
}
