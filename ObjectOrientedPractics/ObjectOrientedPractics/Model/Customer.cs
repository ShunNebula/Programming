using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Полное имя (фио) покупателя
        /// </summary>
        private string _fullname;
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
        public string Fullname 
        { 
            get {  return _fullname; } 
            set 
            { 
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                _fullname = value; 
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
        public Customer()
        {
            Id = IdGenerator.GetNextId("Customer");
        }
    }
}
