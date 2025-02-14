using ObjectOrientedPractices.Services;
using ObjectOrientedPractices.Model.Enums;
using System.Windows.Forms;
using System;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Хранит данные о товаре
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        /// <summary>
        /// Событие для изменения названия товара
        /// </summary>
        public event EventHandler NameChanged;

        /// <summary>
        /// Событие для изменения цены товара
        /// </summary>
        public event EventHandler CostChanged;

        /// <summary>
        /// Событие для изменения информации товара
        /// </summary>
        public event EventHandler InfoChanged;

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
                try
                { 
                    ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                    if (_name != value)
                    {
                        _name = value;
                        NameChanged?.Invoke(this, EventArgs.Empty);
                    }
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                try
                { 
                    ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                    if (_info != value)
                    {
                        _info = value;
                        InfoChanged?.Invoke(this, EventArgs.Empty);
                    }
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                try
                {
                    ValueValidator.AssertValueInRange(value, 0, 100000, nameof(Cost));
                    if (_cost != value)
                    {
                        _cost = value;
                        CostChanged?.Invoke(this, EventArgs.Empty);
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт категорию товара
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара</param>
        /// <param name="info">Информация о товаре</param>
        /// <param name="cost">Цена товара</param>
        /// <param name="category">Категория товара</param>
        public Item(string name, string info, double cost, Category category)
        {
            Id = IdGenerator.GetNextId<Item>();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        /// <inheritdoc/>
        public object Clone()
        {
            return new Item(Name, Info, Cost, Category);
        }

        /// <inheritdoc/>
        public bool Equals(Item other)
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
            return Equals((Item)other);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <inheritdoc/>
        public int CompareTo(Item other)
        {
            return Cost.CompareTo(other.Cost);
        }

        public override string ToString()
        {
            return $"{Id}. {Name}";
        }
    }
}
